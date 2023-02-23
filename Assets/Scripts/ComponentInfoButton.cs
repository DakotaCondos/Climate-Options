using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentInfoButton : MonoBehaviour
{
    ComponentInfoPanel componentInfoPanel;
    public  ClimateControlComponent component;

    private void Awake()
    {
        componentInfoPanel = FindObjectOfType<ComponentInfoPanel>();
    }

    public void ShowComponentInfo()
    {
        componentInfoPanel.UpdateComponentInfoPanel(component);
    }
}
