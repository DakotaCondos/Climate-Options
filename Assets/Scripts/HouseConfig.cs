using System;
using System.Collections.Generic;

[Serializable]
public class HouseConfig
{
    public List<RoomConfig> rooms;
    public List<ClimateControlComponent> components;
    public int size;

    public HouseConfig()
    {
        rooms = new List<RoomConfig>();
        components = new List<ClimateControlComponent>();
        size = 0;
    }

    public HouseConfig(List<RoomConfig> rooms, List<ClimateControlComponent> components)
    {
        this.rooms = rooms;
        this.components = components;
    }
    public HouseConfig(List<RoomConfig> rooms, List<ClimateControlComponent> components, int size)
    {
        this.rooms = rooms;
        this.components = components;
        this.size = size;
    }

    public RoomConfig GetRoomByID(int roomID)
    {
        foreach (RoomConfig roomConfig in rooms)
        {
            if (roomConfig.roomNumber == roomID)
                return roomConfig;
        }
        return null;
    }

    public List<ClimateControlComponent> GetAllComponents()
    {
        List<ClimateControlComponent> allComponents = new(components);
        foreach (RoomConfig room in rooms)
        {
            allComponents.AddRange(room.components);
        }

        return allComponents;
    }
}