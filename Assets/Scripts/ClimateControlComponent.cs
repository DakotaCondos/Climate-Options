using System;
using System.Collections.Generic;

[Serializable]
public class ClimateControlComponent
{
    private readonly string name;
    private readonly string description;
    private readonly string pros;
    private readonly string cons;
    private readonly ClimateControlComponentTypes[] prerequisiteComponentType;
    private readonly bool isWholeHomeComponent;
    private readonly bool isHeating;
    private readonly bool isCooling;
    private readonly float heatingBTUOutput;
    private readonly float coolingBTUOutput;
    private readonly float heatingCostPerBTU;
    private readonly float coolingCostPerBTU;
    private readonly ClimateControlComponentTypes componentType;
    private readonly UtilityType utilityType;

    public string Name => name;
    public string Description => description;
    public string Pros => pros;
    public string Cons => cons;
    public bool IsWholeHomeComponent => isWholeHomeComponent;
    public bool IsHeating { get => isHeating; }
    public bool IsCooling { get => isCooling; }
    public float HeatingBTUOutput { get => heatingBTUOutput; }
    public float CoolingBTUOutput { get => coolingBTUOutput; }
    public float HeatingCostPerBTU { get => heatingCostPerBTU; }
    public float CoolingCostPerBTU { get => coolingCostPerBTU; }
    public ClimateControlComponentTypes[] PrerequisiteComponentType { get => prerequisiteComponentType; }
    public ClimateControlComponentTypes ComponentType => componentType;
    public UtilityType UtilityType => utilityType;

    public ClimateControlComponent(
        string name, string description, string pros, string cons,
        ClimateControlComponentTypes[] prerequisiteComponentType,
        bool isWholeHomeComponent, bool isHeating, bool isCooling,
        float heatingBTUOutput, float coolingBTUOutput, float heatingCostPerBTU,
        float coolingCostPerBTU, ClimateControlComponentTypes componentType,
        UtilityType utilityType)
    {
        this.name = name;
        this.description = description;
        this.pros = pros;
        this.cons = cons;
        this.prerequisiteComponentType = prerequisiteComponentType;
        this.isWholeHomeComponent = isWholeHomeComponent;
        this.isHeating = isHeating;
        this.isCooling = isCooling;
        this.heatingBTUOutput = heatingBTUOutput;
        this.coolingBTUOutput = coolingBTUOutput;
        this.heatingCostPerBTU = heatingCostPerBTU;
        this.coolingCostPerBTU = coolingCostPerBTU;
        this.componentType = componentType;
        this.utilityType = utilityType;
    }
}