using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySwitcherHelper : MonoBehaviour
{
    DisplaySwitcher displaySwitcher;
    private void Awake()
    {
        displaySwitcher = FindObjectOfType<DisplaySwitcher>();
    }

    public void Activate(int index)
    {
        displaySwitcher.SwitchDisplay(index);
    }
}
