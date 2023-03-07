using System;
using System.Collections.Generic;
using System.Linq;

public class CostCalculation
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    ClimateDataMonth[] climateDataMonths;

    public float partsCostLow = 0;
    public float partsCostHigh = 0;
    public float operationCost = 0;
    //(HeatingCost, CoolingCost)[]
    public (decimal, decimal)[] monthlyOperationCosts = new (decimal, decimal)[12];
    public List<ClimateControlComponent> masterComponentsList = new();
    public float houseVolume = 0;
    public float totalHeatingBTUOutput = 0;
    public float totalCoolingBTUOutput = 0;
    public decimal averageHeatingCostPerBTU = 0;
    public decimal averageCoolingCostPerBTU = 0;




    public CostCalculation(ClimateControlSystemConfig climateControlSystemConfig, ClimateDataMonth[] climateDataMonths)
    {
        this.climateControlSystemConfig = climateControlSystemConfig;
        ExtractPartInformation();
        CalculateMonthlyOperationCosts();
    }


    private void ExtractPartInformation()
    {
        decimal totalHeatingCostsPerBTU = 0;
        decimal totalCoolingCostsPerBTU = 0;

        foreach (ClimateControlComponent item in climateControlSystemConfig.houseConfig.components)
        {
            masterComponentsList.Add(item);
            partsCostLow += item.priceRange.Item1;
            partsCostHigh += item.priceRange.Item2;
            totalHeatingBTUOutput += item.heatingBTUOutput;
            totalCoolingBTUOutput += item.coolingBTUOutput;
            if (item.isHeating)
            {
                totalHeatingCostsPerBTU += item.heatingCostPerBTU;
            }
            if (item.isCooling)
            {
                totalCoolingCostsPerBTU += item.coolingCostPerBTU;
            }
        }

        foreach (RoomConfig room in climateControlSystemConfig.houseConfig.rooms)
        {
            houseVolume += room.size;

            foreach (ClimateControlComponent item in room.components)
            {
                masterComponentsList.Add(item);
                partsCostLow += item.priceRange.Item1;
                partsCostHigh += item.priceRange.Item2;
                totalHeatingBTUOutput += item.heatingBTUOutput;
                totalCoolingBTUOutput += item.coolingBTUOutput;
                if (item.isHeating)
                {
                    totalHeatingCostsPerBTU += item.heatingCostPerBTU;
                }
                if (item.isCooling)
                {
                    totalCoolingCostsPerBTU += item.coolingCostPerBTU;
                }
            }
        }

        averageHeatingCostPerBTU = (decimal)(totalHeatingCostsPerBTU / masterComponentsList.Select(x => x.isHeating == true).Count());
        averageCoolingCostPerBTU = (decimal)(totalCoolingCostsPerBTU / masterComponentsList.Select(x => x.isCooling == true).Count());
    }
    private void CalculateMonthlyOperationCosts()
    {
        /* Calculating Operational Costs 
         * we have the house square footage, multiplied by 9 ft for ceiling height = total cubic feet of air space
         * 1 BTU will raise temperature 1 degree Fahrenheit per 55 cubic feet, so divide by 55
         * desired inside temp(70f) - outside temp = temperature delta (+ is heat, - is cool)
         * (total cubic feet * temperature change) / 55 = INITIAL required BTU 
         * 
         * heat loss =  Surface Heat Loss(wall loss + ceiling loss) + Air Infiltration Heat Loss
         * Surface Heat Loss in British Thermal Units per Hour (BTUH) = U value x surface area x Delta T
         * U value for home walls with code approved insulation = 0.7
         * U value for home ceiling with code approved insulation = 0.53
         * 
         * ceiling area estimate = 1.3 * total square footage
         * wall area is estimated from total sq footage:
         * squareRT(total square footage)*8 -> gives perfect square house, multiply by 1.3 for irregularity in home shape
         * 
         * Air Infiltration Heat Loss in BTUH = Room volume x Delta T x Air Changes per Hour (ACH) x .018.
         * typical ACH rate is 4
         */

        // One BTU will raise temperature 1 degree per 55 cubic feet
        // Initial temperature change = (house volume * temperature delta) / 55
        // apply this every month to deal with non-calculated losses like appliance use, opening/closing doors & windows etc..

        // establish house calculation values
        double ceilingArea = (houseVolume / 9) * 1.3; // update this after the merge
        double wallArea = 1.3 * MathF.Sqrt(houseVolume / 9);
        double uValueWall = 0.7;
        double uValueCeiling = 0.7;
        double desiredTemperature = 70;
        double ACH = 4;
        double cubicFeetPerBTU = 55;


        for (int i = 0; i < monthlyOperationCosts.Length; i++)
        {
            monthlyOperationCosts[i].Item1 = 0;
            monthlyOperationCosts[i].Item2 = 0;

            double temperatureDelta = desiredTemperature - KelvinToFahrenheit(climateDataMonths[i].averageTemperature);
            double surfaceLossWall = uValueWall * wallArea * temperatureDelta;
            double surfaceLossCeiling = uValueCeiling * ceilingArea * temperatureDelta;
            double airInfiltrationLoss = houseVolume * temperatureDelta * ACH * 0.18;
            double BTUHLoss = surfaceLossWall + surfaceLossCeiling + airInfiltrationLoss;
            double initialChangeBTU = (houseVolume * temperatureDelta) / cubicFeetPerBTU;

            int avgHrsPerMonth = (365 * 24) / 12;

            if (temperatureDelta > 0)
            {
                //use heating
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (decimal)initialChangeBTU;
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (decimal)(avgHrsPerMonth * BTUHLoss);
            }
            else
            {
                //use cooling
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (decimal)initialChangeBTU;
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (decimal)(avgHrsPerMonth * BTUHLoss);
            }
        }
    }

    private double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * (9 / 5) + 32;
    }
}