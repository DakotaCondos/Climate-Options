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
    public ClimateControlComponentTypes prerequisiteComponentType;
    public bool isWholeHomeComponent;
    public bool isHeating;
    public bool isCooling;
    public float heatingBTUOutput;
    public float coolingBTUOutput;
    public decimal heatingCostPerBTU;
    public decimal coolingCostPerBTU;
    public ClimateControlComponentTypes componentType;
    public UtilityType utilityType;
    public (float, float) priceRange;
    public string imagePath = "";
    public ClimateControlComponent()
    {
        this.componentName = "TestComponent";
        this.description = "Description of TestComponent";
        this.pros = "Pros of TestComponent";
        this.cons = "Cons of TestComponent";
        this.prerequisiteComponentType = ClimateControlComponentTypes.None;
        this.isWholeHomeComponent = false;
        this.isHeating = false;
        this.isCooling = false;
        this.heatingBTUOutput = 0;
        this.coolingBTUOutput = 0;
        this.heatingCostPerBTU = 0;
        this.coolingCostPerBTU = 0;
        this.componentType = ClimateControlComponentTypes.None;
        this.utilityType = UtilityType.Electric;
        this.priceRange = (10.0f, 100.0f);
    }

    public ClimateControlComponent(
        string name, string description, string pros, string cons,
        ClimateControlComponentTypes prerequisiteComponentType,
        bool isWholeHomeComponent, bool isHeating, bool isCooling,
        float heatingBTUOutput, float coolingBTUOutput, decimal heatingCostPerBTU,
        decimal coolingCostPerBTU, ClimateControlComponentTypes componentType,
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