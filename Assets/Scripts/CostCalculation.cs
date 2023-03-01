using System;

public class CostCalculation
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public float partsCostLow = 0;
    public float partsCostHigh = 0;
    public float operationCost = 0;
    //     (HeatingCost, CoolingCost)[]
    public (float, float)[] monthlyOperationCosts = new (float, float)[12];


    public CostCalculation(ClimateControlSystemConfig climateControlSystemConfig)
    {
        this.climateControlSystemConfig = climateControlSystemConfig;
        CalculatePartsCost();
        CalculateMonthlyOperationCosts();
    }


    private void CalculatePartsCost()
    {
        foreach (ClimateControlComponent item in climateControlSystemConfig.houseConfig.components)
        {
            partsCostLow += item.priceRange.Item1;
            partsCostHigh += item.priceRange.Item2;
        }

        foreach (RoomConfig room in climateControlSystemConfig.houseConfig.rooms)
        {
            foreach (ClimateControlComponent item in room.components)
            {
                partsCostLow += item.priceRange.Item1;
                partsCostHigh += item.priceRange.Item2;
            }

        }
    }
    private void CalculateMonthlyOperationCosts()
    {
        // TO-DO
    }
}