using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.WSA;
//using UtilityRates;


public class UtilRateLookup : MonoBehaviour
{
    // Start is called before the first frame update
    public UtilityRates GetRates(int zipCode)
    {
        var file = UnityEngine.Application.streamingAssetsPath + $"/UtiltyRatesFile/state_rates.csv";
        var csvFile = File.ReadAllLines(file).Skip(1).Where(row => row.Length > 0).Select(UtilityRates.ParseRow).ToList();

        float electric = GetElect(zipCode, csvFile);
        float gas = GetGas(zipCode, csvFile);
        float oil = GetOil(zipCode, csvFile);
        float wood = GetWood(zipCode, csvFile);

        
        UtilityRates rate = new(zipCode,electric, gas, oil, wood);
        return rate;
    }


    internal static float GetElect(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select (r.ElectricityPerKWH));
        return item.Sum();
    }

    internal static float GetGas(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.GasPerTherm);
        return item.Sum();
    }

    internal static float GetOil(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.OilPerGallon);
        return item.Sum();
    }
    internal static float GetWood(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.WoodPerPound);
        return item.Sum();
    }
}
