using System.Collections;
using System.Linq;
using UnityEngine;

public class UtilityRates
{
    private int zipCode;
    private float electricityPerKWH;
    private float gasPerTherm;
    private float oilPerGallon;
    private float woodPerPound;

    public int ZipCode { get => zipCode; }
    public float ElectricityPerKWH { get => electricityPerKWH; }
    public float GasPerTherm { get => gasPerTherm; }
    public float OilPerGallon { get => oilPerGallon; }
    public float WoodPerPound { get => woodPerPound; }

    public UtilityRates(int zipCode, float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.zipCode = zipCode;
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }
    public UtilityRates(float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }

    public UtilityRates() { }

    internal static UtilityRates ParseRow(string row)
    {

        var columns = row.Split(',');
        return new UtilityRates()
        {
            zipCode = int.Parse(columns[1]),
            electricityPerKWH = float.Parse(columns[2]),
            gasPerTherm = float.Parse(columns[3]),
            oilPerGallon = float.Parse(columns[4]),
            woodPerPound = float.Parse(columns[5])
        };

    }

}