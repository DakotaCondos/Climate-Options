using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NovaExpandableContainer : MonoBehaviour
{
    [SerializeField] UIBlock2D container;
    [SerializeField] UIBlock2D arrowIcon;
    public bool isExpanded = false;
    public float expandDuration = 0.3f;
    public float contractedSize = 0f;
    private Vector3 originalSize;

    private void Start()
    {
        if (container != null && arrowIcon != null)
        {
            //calculate size as if fully expanded
            container.AutoSize.Y = AutoSize.Expand;
            container.CalculateLayout();
            originalSize = container.Size.Raw;

            //remove AutoSize 
            container.AutoSize.Y = AutoSize.None;

            //initialize based on isExpanded
            UpdateExpandedState(false);
        }
    }

    private void UpdateExpandedState(bool useAnimation)
    {
        if (isExpanded)
        {
            Expand(useAnimation);
        }
        else
        {
            Contract(useAnimation);
        }
    }

    private void Contract(bool useAnimation)
    {
        if (useAnimation)
        {
            container.ScaleSizeTo(new Vector3(originalSize.x, contractedSize, originalSize.z), expandDuration);
        }
        else
        {
            container.Size = new Vector3(originalSize.x, contractedSize, originalSize.z);
        }
        arrowIcon.transform.rotation = Quaternion.identity;
        container.Visible = false;
        container.GetComponentsInChildren<UIBlock2D>().ToList().ForEach(e => { e.Visible = false; });
        container.GetComponentsInChildren<TextBlock>().ToList().ForEach(e => { e.Visible = false; });
    }

    private void Expand(bool useAnimation)
    {
        container.Visible = true;
        container.GetComponentsInChildren<UIBlock2D>().ToList().ForEach(e => { e.Visible = true; });
        container.GetComponentsInChildren<TextBlock>().ToList().ForEach(e => { e.Visible = true; });
        if (useAnimation)
        {
            container.ScaleSizeTo(originalSize, expandDuration);
        }
        else
        {
            container.Size = originalSize;
        }
        arrowIcon.transform.rotation = Quaternion.Euler(0, 0, 180);
    }

    public void ToggleExpand()
    {
        isExpanded = !isExpanded;
        UpdateExpandedState(true);
    }
}
