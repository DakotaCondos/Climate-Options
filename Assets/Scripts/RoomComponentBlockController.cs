//#if UNITY_EDITOR
using Nova;
using System.Collections.Generic;
using UnityEngine;

public class RoomComponentBlockController : MonoBehaviour
{
    public TextBlock roomNameLabel;
    public List<ClimateControlComponent> components;
    public List<GameObject> displayedPrefabs = new();

    public GameObject prefab;

    public void DrawComponentDetailsBlocks()
    {
        if (prefab == null) return;

        foreach (GameObject item in displayedPrefabs)
        {
            Destroy(item);
        }

        foreach (ClimateControlComponent item in components)
        {
            GameObject g = Instantiate(prefab, transform);
            ComponentDetailBlockController componentDetailBlockController = g.GetComponent<ComponentDetailBlockController>();
            componentDetailBlockController.component = item;
            componentDetailBlockController.label.Text = item.componentName;
            componentDetailBlockController.roomComponentBlockController = this;
            displayedPrefabs.Add(g);
        }

    }

    public bool RemoveComponent(ClimateControlComponent component)
    {
        if (components.Contains(component))
        {
            components.Remove(component);
            return true;
        }
        return false;
    }
}
// current file contents
//#endif