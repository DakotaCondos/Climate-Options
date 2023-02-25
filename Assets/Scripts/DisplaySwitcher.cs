using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class DisplaySwitcher : MonoBehaviour
{
    [SerializeField] List<GameObject> Displays = new();

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
}