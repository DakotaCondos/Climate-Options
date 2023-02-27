
using System;

[Serializable]
public class UtilityRates
{
    public float electricityPerKWH;
    public float gasPerTherm;
    public float oilPerGallon;
    public float woodPerPound;

    public float ElectricityPerKWH { get => electricityPerKWH; }
    public float GasPerTherm { get => gasPerTherm; }
    public float OilPerGallon { get => oilPerGallon; }
    public float WoodPerPound { get => woodPerPound; }

    public UtilityRates(float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }
}