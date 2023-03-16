#if UNITY_EDITOR
using UnityEngine;
using Nova;

public class NovaUIBehavior : MonoBehaviour
{
    public void DisableNovaInteractableClickBehavior(GameObject gameObject)
    {
        Interactable interactable = gameObject.GetComponent<Interactable>();

        if (interactable != null)
        {
            interactable.ClickBehavior = ClickBehavior.None;
        }
    }

    public void ToggleBorderVisibility(UIBlock2D uIBlock2D)
    {
        uIBlock2D.Border.Enabled = !uIBlock2D.Border.Enabled;
    }

    public void BorderVisibility(UIBlock2D uIBlock2D, bool value)
    {
        uIBlock2D.Border.Enabled = value;
    }
}
// current file contents
#endif