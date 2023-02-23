using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateControlSystemConfig
{
    public HouseConfig houseConfig;
    public UtilityConfig utilityConfig;

    public ClimateControlSystemConfig()
    {
    }

    public ClimateControlSystemConfig(HouseConfig houseConfig, UtilityConfig utilityConfig)
    {
        this.houseConfig = houseConfig;
        this.utilityConfig = utilityConfig;
    }

}
