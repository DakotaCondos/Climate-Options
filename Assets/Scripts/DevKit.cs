using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevKit : MonoBehaviour
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
    public float heatingCostPerBTU;
    public float coolingCostPerBTU;
    public ClimateControlComponentTypes componentType;
    public UtilityType utilityType;
    public float priceLow;
    public float priceHigh;
    public string imagePath = "";


    public ClimateControlComponent component;
    public ClimateControlComponentFactory factory;

    private void Awake()
    {
        factory = GetComponent<ClimateControlComponentFactory>();
    }


    [ContextMenu("Build Component")]
    void BuildComponent()
    {
        component = new(componentName,
                        description,
                        pros,
                        cons,
                        prerequisiteComponentType,
                        isWholeHomeComponent,
                        isHeating,
                        isCooling,
                        heatingBTUOutput,
                        coolingBTUOutput,
                        heatingCostPerBTU,
                        coolingCostPerBTU,
                        componentType,
                        utilityType,
                        priceLow,
                        priceHigh);

        if (component == null)
        {
            print("ComponentIsNull");
            return;
        }
    }

    [ContextMenu("Write Component")]
    void WriteComponent()
    {
        factory.SaveObjectToJsonFile(component, componentName);
    }

}
