using System;

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

    public UtilityRates()
    {
        electricityPerKWH = 0.23f;
        gasPerTherm = 0.147f;
        oilPerGallon = 4.231f;
        woodPerPound = 0.16f;
    }
}