public class ConfigInfo
{   //this is a helper class for displaying info on the calculation page
    //raw component cost
    public float componentCostLow;
    public float componentCostHigh;
    //operation costs
    public float heatingOperationsCost;
    public float coolingOperationsCost;
    //minimum BTU's
    public float heatingBTURequired;
    public float coolingBTURequired;
    //BTU output
    public float heatingBTUOutput;
    public float coolingBTUOutput;

    public ConfigInfo(float componentCostLow,
                      float componentCostHigh,
                      float heatingOperationsCost,
                      float coolingOperationsCost,
                      float heatingBTURequired,
                      float coolingBTURequired,
                      float heatingBTUOutput,
                      float coolingBTUOutput)
    {
        this.componentCostLow = componentCostLow;
        this.componentCostHigh = componentCostHigh;
        this.heatingOperationsCost = heatingOperationsCost;
        this.coolingOperationsCost = coolingOperationsCost;
        this.heatingBTURequired = heatingBTURequired;
        this.coolingBTURequired = coolingBTURequired;
        this.heatingBTUOutput = heatingBTUOutput;
        this.coolingBTUOutput = coolingBTUOutput;
    }
}