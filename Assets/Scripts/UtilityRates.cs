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
        electricityPerKWH = 1;
        gasPerTherm = 1;
        oilPerGallon = 1;
        woodPerPound = 1;
    }
}