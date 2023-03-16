//#if UNITY_EDITOR
using Nova;
using System.Linq;
using UnityEngine;

public class NovaExpandableContainer : MonoBehaviour
{
    [SerializeField] UIBlock2D container;
    [SerializeField] UIBlock2D arrowIcon;
    public bool isExpanded = false;
    public bool selfInitialize = true;

    private void Start()
    {
        if (selfInitialize) Initialize();
    }

    public void Initialize()
    {
        if (container != null && arrowIcon != null)
        {
            UpdateExpandedState();
        }
    }

    private void UpdateExpandedState()
    {
        if (isExpanded)
        {
            Expand();
        }
        else
        {
            Contract();
        }
    }

    private void Contract()
    {
        arrowIcon.transform.rotation = Quaternion.identity;
        container.AutoSize.Y = AutoSize.None;
        container.Size = new Length3(Length.Percentage(100), Length.Zero, Length.Zero);
        container.GetComponentsInChildren<IVisible>().ToList().ForEach(i => { i.SetVisible(false); });
    }

    private void Expand()
    {
        arrowIcon.transform.rotation = Quaternion.Euler(0, 0, 180);
        container.AutoSize.Y = AutoSize.Shrink;
        container.GetComponentsInChildren<IVisible>().ToList().ForEach(i => { i.SetVisible(true); });
    }

    public void ToggleExpand()
    {
        isExpanded = !isExpanded;
        UpdateExpandedState();
    }
}
// current file contents
//#endif