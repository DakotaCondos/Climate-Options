//#if UNITY_EDITOR
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
// current file contents
//#endif