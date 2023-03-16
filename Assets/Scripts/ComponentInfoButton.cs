#if UNITY_EDITOR
using UnityEngine;

public class ComponentInfoButton : MonoBehaviour
{
    ComponentInfoPanel componentInfoPanel;
    public ClimateControlComponent component;

    private void Awake()
    {
        componentInfoPanel = FindObjectOfType<ComponentInfoPanel>(true);
    }

    public void ShowComponentInfo()
    {
        componentInfoPanel.UpdateComponentInfoPanel(component);
    }
}
// current file contents
#endif