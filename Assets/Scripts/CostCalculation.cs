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
    public (double, double)[] monthlyOperationCosts = new (double, double)[12];
    public List<ClimateControlComponent> masterComponentsList = new();
    public float houseVolume = 0;
    public float totalHeatingBTUOutput = 0;
    public float totalCoolingBTUOutput = 0;
    public double averageHeatingCostPerBTU = 0;
    public double averageCoolingCostPerBTU = 0;

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
        double totalHeatingCostsPerBTU = 0;
        double totalCoolingCostsPerBTU = 0;

        foreach (ClimateControlComponent item in climateControlSystemConfig.houseConfig.components)
        {
            masterComponentsList.Add(item);
            partsCostLow += item.priceLow;
            partsCostHigh += item.priceHigh;
            totalHeatingBTUOutput += item.heatingBTUOutput;
            totalCoolingBTUOutput += item.coolingBTUOutput;
            if (item.isHeating)
            {
                totalHeatingCostsPerBTU += item.heatingCostPerBTU * GetUtilRate(item);
                messages.Add($"{item.componentName} heatingCostPerBTU: {item.heatingCostPerBTU * GetUtilRate(item)}\n" +
                    $"item.heatingCostPerBTU: {item.heatingCostPerBTU}\n" +
                    $"GetUtilRate(item): {GetUtilRate(item)}");
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
                partsCostLow += item.priceLow;
                partsCostHigh += item.priceHigh;
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

        int totalHeating = 0;
        int totalCooling = 0;

        foreach (var item in masterComponentsList)
        {
            if (item.isHeating) totalHeating++;
            if (item.isCooling) totalCooling++;
        }

        averageHeatingCostPerBTU = (totalHeating > 0) ? (totalHeatingCostsPerBTU / totalHeating) : 0;
        averageCoolingCostPerBTU = (totalCooling > 0) ? (totalCoolingCostsPerBTU / totalCooling) : 0;

        messages.Add($"totalHeatingCostsPerBTU: {totalHeatingCostsPerBTU}\n" +
            $"totalCoolingCostsPerBTU: {totalCoolingCostsPerBTU}\n" +
            $"averageHeatingCostPerBTU: {averageHeatingCostPerBTU}\n" +
            $"averageCoolingCostPerBTU: {averageCoolingCostPerBTU}\n" +
            $"total heating components: {totalHeating}\n" +
            $"total cooling components: {totalCooling}");
    }

    private float GetUtilRate(ClimateControlComponent component)
    {
        UtilityRates rates = climateControlSystemConfig.utilityConfig.utilityrates;
        return component.utilityType switch
        {
            UtilityType.Electric => rates.electricityPerKWH,
            UtilityType.Gas => rates.gasPerTherm,
            UtilityType.Oil => rates.oilPerGallon,
            UtilityType.WoodPellet => rates.woodPerPound,
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
        //messages.Add($"ceilingArea:{ceilingArea}");
        //messages.Add($"wallArea:{wallArea}");
        //messages.Add($"houseVolume:{houseVolume}");
        //messages.Add($"averageHeatingCostPerBTU:{averageHeatingCostPerBTU}");
        //messages.Add($"averageCoolingCostPerBTU:{averageCoolingCostPerBTU}");
        //messages.Add($"Heating BTU's per Dollar:{Decimal.Truncate(1m / averageHeatingCostPerBTU)}");
        //messages.Add($"Cooling BTU's per Dollar:{Decimal.Truncate(1m / averageCoolingCostPerBTU)}");


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
            double BTUHLossWindow = UsageNormalization(temperatureDelta);

            if (temperatureDelta > 0)
            {
                //use heating
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (dailyChangeBTU * daysPerMonth);
                monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (avgHrsPerMonth * BTUHLoss) * BTUHLossWindow;
                //monthlyOperationCosts[i].Item1 += averageHeatingCostPerBTU * (avgHrsPerMonth * BTUHLoss);
            }
            else
            {
                //use cooling
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (dailyChangeBTU * daysPerMonth);
                monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (avgHrsPerMonth * BTUHLoss) * BTUHLossWindow;
                //monthlyOperationCosts[i].Item2 += averageCoolingCostPerBTU * (avgHrsPerMonth * BTUHLoss);
            }

            //flip negative cooling cost
            monthlyOperationCosts[i].Item2 *= -1;


            //debug log month data
            //messages.Add($"Month[{i}]:\n" +
            //    $"temperatureDelta:{temperatureDelta}\n" +
            //    $"KelvinAvg:{climateDataMonths[i].averageTemperature}\n" +
            //    $"KelvinToFahrenheit:{KelvinToFahrenheit(climateDataMonths[i].averageTemperature)}\n" +
            //    $"surfaceLossWall:{surfaceLossWall}\n" +
            //    $"surfaceLossCeiling:{surfaceLossCeiling}\n" +
            //    $"airInfiltrationLoss:{airInfiltrationLoss}\n" +
            //    $"BTUHLoss:{BTUHLoss}\n" +
            //    $"initialChangeBTU:{dailyChangeBTU}");
        }
    }

    private double UsageNormalization(double temperatureDelta)
    {
        // non technical normalization for factors like sun exposure, elevation, humidity, slab temperature loss etc..

        switch (temperatureDelta)
        {
            case double n when (n >= 30):
                return .85;

            case double n when (n < 30 && n >= 20):
                return .95;

            case double n when (n < 20 && n >= 10):
                return 1;

            case double n when (n < 10 && n >= 0):
                return 1.15;

            default:
                return 1.3;
        }
    }

    private double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * 9.0 / 5.0 + 32.0;
    }
}