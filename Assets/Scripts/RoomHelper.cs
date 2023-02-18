using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomHelper : MonoBehaviour
{
    //has a reference to a room in the house
    public List<ClimateControlComponent> componentsList;
    private ComponentSelectionController componentSelectionController;

    private void Awake()
    {
        componentSelectionController = FindObjectOfType<ComponentSelectionController>();
    }

    public void SetComponentListToEdit()
    {
        componentSelectionController.componentListBeingEdited = componentsList;
    }
}
