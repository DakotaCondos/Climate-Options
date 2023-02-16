using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ClimateControlComponent
{
    public string componentName;
    public string description;
    public string pros;
    public string cons;
    public List<ClimateControlComponentTypes> prerequisiteComponentType;
    public bool isWholeHomeComponent;
    public bool isHeating;
    public bool isCooling;
    public float heatingBTUOutput;
    public float coolingBTUOutput;
    public float heatingCostPerBTU;
    public float coolingCostPerBTU;
    public ClimateControlComponentTypes componentType;
    public UtilityType utilityType;
    public (float, float) priceRange;

    public ClimateControlComponent(
        string name, string description, string pros, string cons,
        List<ClimateControlComponentTypes> prerequisiteComponentType,
        bool isWholeHomeComponent, bool isHeating, bool isCooling,
        float heatingBTUOutput, float coolingBTUOutput, float heatingCostPerBTU,
        float coolingCostPerBTU, ClimateControlComponentTypes componentType,
        UtilityType utilityType, (float, float) priceRange)
    {
        this.componentName = name;
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
        this.priceRange = priceRange;
    }
}