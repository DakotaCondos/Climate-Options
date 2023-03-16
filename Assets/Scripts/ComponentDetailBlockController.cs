#if UNITY_EDITOR
using Nova;
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
// current file contents
#endif