using System;

public class ClimateControlComponent
{
    private readonly string name;
    private readonly string description;
    private readonly string pros;
    private readonly string cons;
    private readonly bool isParentComponent;
    private readonly bool isChildComponent;
    private readonly bool isHeating;
    private readonly bool isCooling;
    private readonly float heatingBTUOutput;
    private readonly float coolingBTUOutput;
    private readonly float heatingCost;
    private readonly float coolingCost;

    public string Name => name;
    public string Description => description;
    public string Pros => pros;
    public string Cons => cons;
    public bool IsParentComponent { get => isParentComponent; }
    public bool IsChildComponent { get => isChildComponent; }
    public bool IsHeating { get => isHeating; }
    public bool IsCooling { get => isCooling; }
    public float HeatingOutput { get => heatingBTUOutput; }
    public float CoolingOutput { get => coolingBTUOutput; }
    public float HeatingCost { get => heatingCost; }
    public float CoolingCost { get => coolingCost; }

    public readonly ClimateControlComponentTypes componentType;
    public readonly UtilityType utilityType;


}