using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentInfoPanel : MonoBehaviour
{
    public ProgramManager programManager;

    public TextBlock componentName;
    public TextBlock description;
    public TextBlock utilType;
    public TextBlock preReq;
    public TextBlock cost;
    public TextBlock pros;
    public TextBlock cons;
    public UIBlock2D pictureBlock;
    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
    }

    public void UpdateComponentInfoPanel(ClimateControlComponent component)
    {
        if (component == null) return;
        componentName.Text = component.componentName;
        description.Text = component.description;
        utilType.Text = "Utility Type: " + component.utilityType.ToString();
        preReq.Text = "Required Components: " + ConvertEnumListToString(component);
        cost.Text = $"Price: ${component.priceLow} - ${component.priceHigh}";
        pros.Text = "Pros: " + component.pros;
        cons.Text = "Pros: " + component.cons;
        //picture block goes here


    }

    private string ConvertEnumListToString(ClimateControlComponent component)
    {
        return string.Join(", ", component.prerequisiteComponentType);
    }

}
