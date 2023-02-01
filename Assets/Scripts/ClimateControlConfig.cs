using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateControlConfig
{
    HouseConfig houseConfig;
    UtilityConfig utilityConfig;


    public ClimateControlConfig(HouseConfig houseConfig, UtilityConfig utilityConfig)
    {
        this.houseConfig = houseConfig;
        this.utilityConfig = utilityConfig;
    }
}
