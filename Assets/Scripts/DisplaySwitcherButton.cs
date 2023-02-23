using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySwitcherButton : MonoBehaviour
{

    [SerializeField] DisplaySwitcher displaySwitcher;
    [SerializeField] GameObject display;

    public void Activated()
    {
        displaySwitcher.SwitchDisplay(display);
    }
}
