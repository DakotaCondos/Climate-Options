using System;
using UnityEngine;

[Serializable]
public class UtilityRates
{

    public float electricityPerKWH;
    public float gasPerTherm;
    public float oilPerGallon;
    public float woodPerPound;

    public UtilityRates(float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }
}