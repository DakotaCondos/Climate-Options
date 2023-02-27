using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ClimateControlComponents
{
    public List<ClimateControlComponent> components;

    public ClimateControlComponents(List<ClimateControlComponent> components)
    {
        this.components = components;
    }
}
