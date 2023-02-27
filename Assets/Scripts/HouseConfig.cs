using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HouseConfig
{
    //public List<RoomConfig> rooms;
    //public List<ClimateControlComponent> components;

    public RoomConfigs rooms;
    public ClimateControlComponents components;

    public HouseConfig()
    {
        rooms = new RoomConfigs(new List<RoomConfig>());
        components = new ClimateControlComponents(new List<ClimateControlComponent>());
    }

    public HouseConfig(RoomConfigs rooms, ClimateControlComponents components)
    {
        this.rooms = rooms;
        this.components = components;
    }

    public RoomConfig GetRoomByID(int roomID)
    {
        foreach (RoomConfig roomConfig in rooms.rooms)
        {
            if (roomConfig.roomNumber == roomID)
                return roomConfig;
        }
        return null;
    }

    public ClimateControlComponents GetAllComponents()
    {
        ClimateControlComponents allComponents = components;
        foreach (RoomConfig room in rooms.rooms)
        {
            allComponents.components.AddRange(room.components.components);
        }

        return allComponents;
    }
}