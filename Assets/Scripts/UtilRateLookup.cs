using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Linq;
using UtilityRates;


public class UtilRateLookup : MonoBehaviour
{
    // Start is called before the first frame update
    public UtilityRates GetRates(int zipCode)
    {
        var csvFile = File.ReadAllLines("state_rates.csv").Skip(1).Where(row => row.Length > 0).Select(UtilityRates.ParseRow).ToList();
        
        float electric = GetElect(zipCode, csvFile);
        float gas = GetGas(zipCode, csvFile);
        float oil = GetOil(zipCode, csvFile);
        float wood = GetWood(zipCode, csvFile);
       
      
        UtilityRates rate = new(electric, gas, oil, wood);
        return UtilityConfigs.Add(rate, zipCode);
    }


    internal static double GetElect(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select (r.ElectricityPerKWH));
        return item.Sum();
    }

    internal static double GetGas(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.GasPerTherm);
        return item.Sum();
    }

    internal static double GetOil(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.OilPerGallon);
        return item.Sum();
    }
    internal static double GetWood(int zip, List<UtilityRates> file)
    {
        var item = (from r in file
                    where r.ZipCode.Equals(zip)
                    select r.WoodPerPound);
        return item.Sum();
    }

