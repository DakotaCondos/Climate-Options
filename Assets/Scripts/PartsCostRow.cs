using Nova;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsCostRow : MonoBehaviour, IVisible
{
    public TextBlock partName;
    public TextBlock partPrice;

    public void SetVisible(bool value)
    {
        partName.Visible = value;
        partPrice.Visible = value;
    }
}
