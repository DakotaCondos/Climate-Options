public class UtilityRates
{
    private double zipCode;
    private float electricityPerKWH;
    private float gasPerTherm;
    private float oilPerGallon;
    private float woodPerPound;

    public float ZipCode { get => zipCode; }
    public float ElectricityPerKWH { get => electricityPerKWH; }
    public float GasPerTherm { get => gasPerTherm; }
    public float OilPerGallon { get => oilPerGallon; }
    public float WoodPerPound { get => woodPerPound; }

    public UtilityRates(float zipCode, float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.zipCode = zipCode;
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }
    public Rates(float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }

    public UtilityRates() { }

    internal static Rates ParseRow(string row)
    {
        var columns = row.Split(',');
        return new Rates()
        {
            zipCode = float.Parse(columns[1]),
            electricityPerKWH = float.Parse(columns[2]),
            gasPerTherm = float.Parse(columns[3]),
            oilPerGallon = float.Parse(columns[4]),
            woodPerPound = float.Parse(columns[5])
        };
    }

}