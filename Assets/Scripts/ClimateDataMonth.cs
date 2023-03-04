public class ClimateDataMonth
{
    public int month;
    public double averageTemperature;

    public ClimateDataMonth()
    {
        month = 0;
        averageTemperature = 0;
    }

    public ClimateDataMonth(int month, double averageTemperature)
    {
        this.month = month;
        this.averageTemperature = averageTemperature;
    }

    public override string ToString()
    {
        return $"Month: {month}, Average Temperature: {averageTemperature}";
    }
}
