using System;
using System.Collections.Generic;

public class ClimateControlComponent
{
    private readonly string name;
    private readonly string description;
    private readonly string pros;
    private readonly string cons;
    private readonly string[] prerequisiteComponents;
    private readonly bool isParentOnlyComponent;
    private readonly bool isChildOnlyComponent;
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
    public bool IsParentOnlyComponent { get => isParentOnlyComponent; }
    public bool IsChildOnlyComponent { get => isChildOnlyComponent; }
    public bool IsHeating { get => isHeating; }
    public bool IsCooling { get => isCooling; }
    public float HeatingOutput { get => heatingBTUOutput; }
    public float CoolingOutput { get => coolingBTUOutput; }
    public float HeatingCost { get => heatingCost; }
    public float CoolingCost { get => coolingCost; }
    public string[] PrerequisiteComponents { get => prerequisiteComponents; }

    public readonly ClimateControlComponentTypes componentType;
    public readonly UtilityType utilityType;

    public List<ClimateControlComponent> parentComponentsList = null;

    public ClimateControlComponent(string name, string description, string pros, string cons, 
        string[] prerequisiteComponents, bool isParentOnlyComponent, bool isChildOnlyComponent,
        bool isHeating, bool isCooling, float heatingBTUOutput, float coolingBTUOutput, float heatingCost, 
        float coolingCost, ClimateControlComponentTypes componentType, UtilityType utilityType)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));
        this.description = description ?? throw new ArgumentNullException(nameof(description));
        this.pros = pros ?? throw new ArgumentNullException(nameof(pros));
        this.cons = cons ?? throw new ArgumentNullException(nameof(cons));
        this.prerequisiteComponents = prerequisiteComponents ?? throw new ArgumentNullException(nameof(prerequisiteComponents));
        this.isParentOnlyComponent = isParentOnlyComponent;
        this.isChildOnlyComponent = isChildOnlyComponent;
        this.isHeating = isHeating;
        this.isCooling = isCooling;
        this.heatingBTUOutput = heatingBTUOutput;
        this.coolingBTUOutput = coolingBTUOutput;
        this.heatingCost = heatingCost;
        this.coolingCost = coolingCost;
        this.componentType = componentType;
        this.utilityType = utilityType;
    }
}