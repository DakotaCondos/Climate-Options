using System.Collections;
using System.Collections.Generic;
using Nova;
using UnityEngine;

public class HouseSceneController : MonoBehaviour
{

    public GameObject[] panels;

    public void CurrentPanel(int panelNumber)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == panelNumber)
            {
                panels[i].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
        if (panelNumber > 0)
        {
            panels[4].SetActive(true);
        }
    }
}
