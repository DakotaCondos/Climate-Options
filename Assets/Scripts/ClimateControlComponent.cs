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
    public double heatingCostPerBTU;
    public double coolingCostPerBTU;
    public ClimateControlComponentTypes componentType;
    public UtilityType utilityType;
    public float priceLow;
    public float priceHigh;
    public string imagePath = "";
    public ClimateControlComponent()
    {
        componentName = "TestComponent";
        description = "Description of TestComponent";
        pros = "Pros of TestComponent";
        cons = "Cons of TestComponent";
        prerequisiteComponentType = ClimateControlComponentTypes.None;
        isWholeHomeComponent = false;
        isHeating = true;
        isCooling = true;
        heatingBTUOutput = 500;
        coolingBTUOutput = 500;
        heatingCostPerBTU = 0.000293f;
        coolingCostPerBTU = 0.000293f;
        componentType = ClimateControlComponentTypes.None;
        utilityType = UtilityType.Electric;
        priceLow = 10;
        priceHigh = 100;
    }

    public ClimateControlComponent(
        string name, string description, string pros, string cons,
        ClimateControlComponentTypes prerequisiteComponentType,
        bool isWholeHomeComponent, bool isHeating, bool isCooling,
        float heatingBTUOutput, float coolingBTUOutput, double heatingCostPerBTU,
        double coolingCostPerBTU, ClimateControlComponentTypes componentType,
        UtilityType utilityType, float priceLow, float priceHigh)
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
        this.priceLow = priceLow;
        this.priceHigh = priceHigh;
    }


}