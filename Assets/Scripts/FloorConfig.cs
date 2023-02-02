using System.Collections.Generic;

public class FloorConfig
{
    public List<RoomConfig> roomConfig;
    public bool hasStairs;
    public int floorNumber;

    public FloorConfig(List<RoomConfig> roomConfig, bool hasStairs, int floorNumber)
    {
        this.roomConfig = roomConfig;
        this.hasStairs = hasStairs;
        this.floorNumber = floorNumber;
    }
    public FloorConfig(bool hasStairs, int floorNumber)
    {
        roomConfig = new();
        this.hasStairs = hasStairs;
        this.floorNumber = floorNumber;
    }

    public RoomConfig GetRoom(int roomNumber)
    {
        foreach (RoomConfig roomConfig in roomConfig)
        {
            if (roomConfig.roomNumber == roomNumber)
                return roomConfig;
        }
        return null;
    }
}