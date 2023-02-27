using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RoomConfigs
{
    public List<RoomConfig> rooms;

    public RoomConfigs(List<RoomConfig> rooms)
    {
        this.rooms = rooms;
    }
}
