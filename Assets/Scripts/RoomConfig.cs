using System;
using System.Collections.Generic;

[Serializable]
public class RoomConfig
{
    public List<ClimateControlComponent> components;
    public int roomNumber;
    public bool isBathroom = false;

    // size in ft^3
    public float size;
    // US average bedroom size is 200 ft^2 * 8 ft ceiling = 1600 ft^3
    // US average bathroom size is 70 ft^2 * 8 ft ceiling = 560 ft^3
    private float defaultBedroomSize = 1600;
    private float defaultBathroomSize = 560;


    public RoomConfig(int roomNumber, bool isBathroom)
    {
        components = new List<ClimateControlComponent>();
        this.roomNumber = roomNumber;
        this.isBathroom = isBathroom;

        size = (isBathroom) ? defaultBathroomSize : defaultBedroomSize;
    }

    public RoomConfig(List<ClimateControlComponent> components, float size, int roomNumber, bool isBathroom)
    {
        this.components = components;
        this.size = size;
        this.roomNumber = roomNumber;
        this.isBathroom = !isBathroom;
    }

}