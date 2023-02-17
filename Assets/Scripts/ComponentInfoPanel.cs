using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentInfoPanel : MonoBehaviour
{
    public ProgramManager programManager;
    int activeComponentIndex = -1;

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

    [ContextMenu("Update Component Info Panel")]
    public void UpdateComponentInfoPanel(int index)
    {
        if (index < 0)
        {
            //make all text fields empty
        }
        else
        {
            ClimateControlComponent component = programManager.components[index];
            if (component == null) return;
            componentName.Text = component.componentName;
            description.Text = component.description;
            utilType.Text = component.utilityType.ToString();
            preReq.Text = component.prerequisiteComponentType.ToString();
            cost.Text = $"${component.priceRange.Item1} - ${component.priceRange.Item2}";
            pros.Text = component.pros;
            cons.Text = component.cons;
            //picture block goes here

        }
    }


    private void Start()
    {

    }



}
