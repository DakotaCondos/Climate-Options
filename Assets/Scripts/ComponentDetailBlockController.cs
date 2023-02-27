using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDetailBlockController : MonoBehaviour
{
    public ClimateControlComponent component;
    public TextBlock label;
    public RoomComponentBlockController roomComponentBlockController;

    public void RemoveComponent()
    {
        if (roomComponentBlockController.RemoveComponent(component))
        {
            FindObjectOfType<ComponentSelectionController>().UpdateComponentsDisplay();
        }

    }
}
