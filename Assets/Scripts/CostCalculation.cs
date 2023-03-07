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
    //     (HeatingCost, CoolingCost)[]
    public (float, float)[] monthlyOperationCosts = new (float, float)[12];
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

    }
}