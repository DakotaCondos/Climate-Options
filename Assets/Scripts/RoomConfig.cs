using System.Collections.Generic;

public class RoomConfig
{
    public List<ClimateControlComponent> components;
    // size in ft^3
    private readonly float size;
    public float Size { get => size; }
    public int roomNumber;

    public RoomConfig(int roomNumber)
    {
        components = new List<ClimateControlComponent>();
        // US average room size is 200 ft^2 * 8 ft ceiling = 1600 ft^3
        size = 1600;
        this.roomNumber = roomNumber;
    }

    public RoomConfig(List<ClimateControlComponent> components, float size, int roomNumber)
    {
        this.components = components;
        this.size = size;
        this.roomNumber = roomNumber;
    }

}