using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HVACType
{
    public enum Type
    {
        Cooling,
        CentralizedHeating,
        DirectedHeating
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public string UtilityType { get; set; }
    public string Prerequisites { get; set; }
    public string Pros { get; set; }
    public string Cons { get; set; }
    public string ApproximateCost { get; set; }

    public Type Kind { get; set; }

}
