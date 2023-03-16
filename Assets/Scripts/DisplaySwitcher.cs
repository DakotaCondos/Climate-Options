//#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DisplaySwitcher : MonoBehaviour
{
    [SerializeField] List<GameObject> Displays = new();
    [SerializeField] BorderActiveGroup borderActiveGroup;

    private void Start()
    {
        SwitchDisplay(Displays.First());
    }

    public void SwitchDisplay(GameObject display)
    {
        foreach (GameObject item in Displays)
        {
            item.SetActive((item.Equals(display)));
        }
    }

    public void SwitchDisplay(int index)
    {
        foreach (GameObject item in Displays)
        {
            item.SetActive(item.Equals(Displays.ElementAt(index)));
        }
        if (borderActiveGroup != null)
        {
            borderActiveGroup.SetActiveBorder(index);
        }
    }
}
// current file contents
//#endif