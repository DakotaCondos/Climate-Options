using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomHelper : MonoBehaviour
{
    //has a reference to a room in the house
    public List<ClimateControlComponent> componentsList;
    private ComponentSelectionController componentSelectionController;
    public bool isWholeHomeButton = false;
    public string areaDisplayName = "";

    private void Awake()
    {
        componentSelectionController = FindObjectOfType<ComponentSelectionController>();
    }
    private void Start()
    {
        if (isWholeHomeButton)
        {
            componentsList = componentSelectionController.houseConfig.components;
        }
    }

    public void SetComponentListToEdit()
    {
        componentSelectionController.componentListBeingEdited = componentsList;
        componentSelectionController.UpdateComponentsDisplay(isWholeHomeButton);
        componentSelectionController.UpdateComponentHeaderLabel(areaDisplayName);
    }
}
