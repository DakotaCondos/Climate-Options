using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class UtilRateLookup
{
    public List<UtilityConfig> utilityConfigs = new();

    public UtilRateLookup()
    {
        SeedUtilityData();
    }

    public void SeedUtilityData()
    {
        utilityConfigs.Add(new UtilityConfig(new UtilityRates(1, 2, 3, 4), 10));
        utilityConfigs.Add(new UtilityConfig(new UtilityRates(11, 22, 33, 44), 20));
        utilityConfigs.Add(new UtilityConfig(new UtilityRates(111, 222, 333, 444), 30));
        utilityConfigs.Add(new UtilityConfig(new UtilityRates(1111, 2222, 3333, 4444), 40));
        utilityConfigs.Add(new UtilityConfig(new UtilityRates(11111, 22222, 33333, 44444), 50));

    }

    public UtilityConfig FindByZipcode(int zipcode)
    {

        UtilityConfig utilityConfig= utilityConfigs.Find(x => x.zip == zipcode);
        Debug.Log($"FindByZipcode: {Newtonsoft.Json.JsonConvert.SerializeObject(utilityConfig)}");
        return utilityConfig;

    }
}
