using System.Collections.Generic;

public class HouseConfig
{
    public List<FloorConfig> floors;
    public List<ClimateControlComponent> components;

    public HouseConfig()
    {
        floors = new List<FloorConfig>();
        components = new List<ClimateControlComponent>();
    }

    public HouseConfig(List<FloorConfig> floors, List<ClimateControlComponent> components)
    {
        this.floors = floors;
        this.components = components;
    }

}