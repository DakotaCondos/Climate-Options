#if UNITY_EDITOR
using Nova;
using UnityEngine;

public class ComponentButton : MonoBehaviour
{
    public ClimateControlComponent component;
    private ComponentSelectionController componentSelectionController;
    [SerializeField] TextBlock textblockLabel;

    private void Awake()
    {
        componentSelectionController = FindObjectOfType<ComponentSelectionController>();
    }
    private void Start()
    {
        textblockLabel.Text = component.componentName;
    }

    public void ActivateButtonPressed()
    {
        var list = componentSelectionController.componentListBeingEdited;
        if (list == null) { return; }
        if (!list.Contains(component))
        {
            list.Add(component);
            componentSelectionController.RedrawInstalledComponents();
        }
    }


}
// current file contents
#endif