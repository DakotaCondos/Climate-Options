public class UtilityRates
{
    private double zipCode;
    private float electricityPerKWH;
    private float gasPerTherm;
    private float oilPerGallon;
    private float woodPerPound;

    public double ZipCode { get => zipCode; }
    public float ElectricityPerKWH { get => electricityPerKWH; }
    public float GasPerTherm { get => gasPerTherm; }
    public float OilPerGallon { get => oilPerGallon; }
    public float WoodPerPound { get => woodPerPound; }

    public UtilityRates(float electricityPerKWH, float gasPerTherm, float oilPerGallon, float woodPerPound)
    {
        this.zipCode = zipCode;
        this.electricityPerKWH = electricityPerKWH;
        this.gasPerTherm = gasPerTherm;
        this.oilPerGallon = oilPerGallon;
        this.woodPerPound = woodPerPound;
    }

    internal static Rates ParseRow(string row)
    {
        var columns = row.Split(',');
        return new Rates()
        {
            zipCode = double.Parse(columns[1]),
            electricityPerKWH = double.Parse(columns[2]),
            gasPerTherm = double.Parse(columns[3]),
            oilPerGallon = double.Parse(columns[4]),
            woodPerPound = double.Parse(columns[5])
        };
    }

}