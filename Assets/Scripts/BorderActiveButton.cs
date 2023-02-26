using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderActiveButton : MonoBehaviour
{
    [SerializeField] BorderActiveGroup borderActiveGroup;

    public void Activated()
    {
        borderActiveGroup.SetActiveBorder(gameObject.GetComponent<UIBlock2D>());
    }
}
