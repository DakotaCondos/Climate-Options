using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class CostCalculation
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public ClimateDataMonth[] climateDataMonths;

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

    //debug component
    public List<string> messages = new List<string>();


    public CostCalculation()
    {
    }


    public CostCalculation(ClimateControlSystemConfig climateControlSystemConfig, ClimateDataMonth[] climateDataMonths)
    {
        this.climateControlSystemConfig = climateControlSystemConfig;
        this.climateDataMonths = climateDataMonths;
        ExtractPartInformation();
        CalculateMonthlyOperationCosts();
    }

    public void Initialize()
    {
        if (climateControlSystemConfig != null && climateDataMonths != null)
        {
            ExtractPartInformation();
            CalculateMonthlyOperationCosts();
        }
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
                totalHeatingCostsPerBTU += item.heatingCostPerBTU * GetUtilRate(item);
            }
            if (item.isCooling)
            {
                totalCoolingCostsPerBTU += item.coolingCostPerBTU * GetUtilRate(item);
            }
        }

        foreach (RoomConfig room in climateControlSystemConfig.houseConfig.rooms)
        {
            foreach (ClimateControlComponent item in room.components)
            {
                masterComponentsList.Add(item);
                partsCostLow += item.priceRange.Item1;
                partsCostHigh += item.priceRange.Item2;
                totalHeatingBTUOutput += item.heatingBTUOutput;
                totalCoolingBTUOutput += item.coolingBTUOutput;
                if (item.isHeating)
                {
                    totalHeatingCostsPerBTU += item.heatingCostPerBTU * GetUtilRate(item);
                }
                if (item.isCooling)
                {
                    totalCoolingCostsPerBTU += item.coolingCostPerBTU * GetUtilRate(item);
                }
            }
        }

        averageHeatingCostPerBTU = (decimal)(totalHeatingCostsPerBTU / masterComponentsList.Select(x => x.isHeating == true).Count());
        averageCoolingCostPerBTU = (decimal)(totalCoolingCostsPerBTU / masterComponentsList.Select(x => x.isCooling == true).Count());
    }

    private decimal GetUtilRate(ClimateControlComponent component)
    {
        UtilityRates rates = climateControlSystemConfig.utilityConfig.utilityrates;
        return component.utilityType switch
        {
            UtilityType.Electric => (decimal)rates.electricityPerKWH,
            UtilityType.Gas => (decimal)rates.gasPerTherm,
            UtilityType.Oil => (decimal)rates.oilPerGallon,
            UtilityType.WoodPellet => (decimal)rates.woodPerPound,
            _ => 0,
        };
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
         * U value for home walls with code approved insulation = 0.07
         * U value for home ceiling with code approved insulation = 0.053
         * 
         * ceiling area estimate = house square footage
         * 
         * wall area is estimated from house square footage:
         *      squareRT(total square footage) -> gives 1 side length for a perfect square house, 
         *      then multiply side length by 4 to get all sides of perfect square house
         *      then multiply by 9 for the height of the wall
         *      then multiply by 1.12 for irregularity in homes shape
         * 
         * Air Infiltration Heat Loss in BTUH = Room volume x Delta T x Air Changes per Hour (ACH) x 0.018.
         */

        // One BTU will raise temperature 1 degree per 55 cubic feet
        // Initial temperature change BTU required = (house volume * temperature delta) / 55
        // apply this every day to estimate non-calculated losses like appliance use, opening/closing doors & windows etc..

        // establish house calculation values
        double ceilingArea = climateControlSystemConfig.houseConfig.size;
        double wallArea = MathF.Sqrt((float)climateControlSystemConfig.houseConfig.size) * 4.0 * 9.0 * 1.12;
        double uValueWall = 0.07;
        double uValueCeiling = 0.053;
        double desiredTemperature = 70.0;
        double ACH = 0.5;
        double cubicFeetPerBTU = 55.0;
        double houseVolume = climateControlSystemConfig.houseConfig.size * 9.0;

        // log debug messages
        messages.Add($"ceilingArea:{ceilingArea}");
        messages.Add($"wallArea:{wallArea}");
        messages.Add($"houseVolume:{houseVolume}");
        messages.Add($"averageHeatingCostPerBTU:{averageHeatingCostPerBTU}");
        messages.Add($"averageCoolingCostPerBTU:{averageCoolingCostPerBTU}");
        messages.Add($"Heating BTU's per Dollar:{Decimal.Truncate(1m / averageHeatingCostPerBTU)}");
        messages.Add($"Cooling BTU's per Dollar:{Decimal.Truncate(1m / averageCoolingCostPerBTU)}");


        for (int i = 0; i < monthlyOperationCosts.Length; i++)
        {
            monthlyOperationCosts[i].Item1 = 0;
            monthlyOperationCosts[i].Item2 = 0;

            double temperatureDelta = desiredTemperature - KelvinToFahrenheit(climateDataMonths[i].averageTemperature);
            double surfaceLossWall = uValueWall * wallArea * temperatureDelta;
            double surfaceLossCeiling = uValueCeiling * ceilingArea * temperatureDelta;
            double airInfiltrationLoss = houseVolume * temperatureDelta * ACH * 0.018;
            double BTUHLoss = surfaceLossWall + surfaceLossCeiling + airInfiltrationLoss;
            double dailyChangeBTU = (houseVolume * temperatureDelta) / cubicFeetPerBTU;
            double daysPerMonth = 365.0 / 12.0;
            int avgHrsPerMonth = (365 * 24) / 12;
            decimal BTUHLossWindow = UsageNormalization(temperatureDelta);

            if (temperatureDelta > 0)
            {
                //use heating
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (decimal)(dailyChangeBTU * daysPerMonth);
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (decimal)(avgHrsPerMonth * BTUHLoss) * BTUHLossWindow;
            }
            else
            {
                //use cooling
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (decimal)(dailyChangeBTU * daysPerMonth);
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (decimal)(avgHrsPerMonth * BTUHLoss) * BTUHLossWindow;
            }

            //flip negative cooling cost
            monthlyOperationCosts[i].Item2 *= -1;


            //debug log month data
            messages.Add($"Month[{i}]:\n" +
                $"temperatureDelta:{temperatureDelta}\n" +
                $"KelvinAvg:{climateDataMonths[i].averageTemperature}\n" +
                $"KelvinToFahrenheit:{KelvinToFahrenheit(climateDataMonths[i].averageTemperature)}\n" +
                $"surfaceLossWall:{surfaceLossWall}\n" +
                $"surfaceLossCeiling:{surfaceLossCeiling}\n" +
                $"airInfiltrationLoss:{airInfiltrationLoss}\n" +
                $"BTUHLoss:{BTUHLoss}\n" +
                $"initialChangeBTU:{dailyChangeBTU}");
        }
    }

    private decimal UsageNormalization(double temperatureDelta)
    {
        // non technical normalization for factors like sun exposure, elevation, humidity, slab temperature loss etc..

        if (temperatureDelta < 0)
        {
            temperatureDelta = -1.5 * temperatureDelta;
        }

        switch (temperatureDelta)
        {
            case double n when (n >= 30):
                return .45m;

            case double n when (n < 30 && n >= 20):
                return .65m;

            case double n when (n < 20 && n >= 10):
                return .85m;

            default:
                return 1m;
        }
    }

    private double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * 9.0 / 5.0 + 32.0;
    }
}