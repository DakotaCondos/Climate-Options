#if UNITY_EDITOR
using System;
using System.Collections.Generic;

[Serializable]
public class ClimateControlSystemConfig
{
    public string name;
    public HouseConfig houseConfig;
    public UtilityConfig utilityConfig;
    public List<string> pictureNames;

    public ClimateControlSystemConfig()
    {
        pictureNames = new List<string>();
        name = "Default";
    }

    public ClimateControlSystemConfig(string name, HouseConfig houseConfig, UtilityConfig utilityConfig)
    {
        this.name = name;
        this.houseConfig = houseConfig;
        this.utilityConfig = utilityConfig;
        pictureNames = new List<string>();
    }

}
// current file contents
#endif