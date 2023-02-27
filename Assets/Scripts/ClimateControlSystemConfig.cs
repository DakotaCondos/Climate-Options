using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateControlSystemConfig
{
    public string name;
    public HouseConfig houseConfig;
    public UtilityConfig utilityConfig;

    public ClimateControlSystemConfig()
    {
    }

    public ClimateControlSystemConfig(string name, HouseConfig houseConfig, UtilityConfig utilityConfig)
    {
        this.name = name;
        this.houseConfig = houseConfig;
        this.utilityConfig = utilityConfig;
    }

}
