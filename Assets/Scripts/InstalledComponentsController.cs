using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InstalledComponentsController : MonoBehaviour
{
    ComponentSelectionController componentSelectionController;
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject instantiateLocation;
    List<RoomComponentBlockController> allRoomComponentBlockControllers = new();



    private void Awake()
    {
        componentSelectionController = FindObjectOfType<ComponentSelectionController>();
    }

    private void Start()
    {
        CreateRooms();
        RedrawComponents();
    }

    private void CreateRooms()
    {
        if (componentSelectionController == null) return;

        //Instantiate Whole Home Room
        RoomComponentBlockController room = RoomBuilder("Whole Home");
        room.components = componentSelectionController.houseConfig.components;
        allRoomComponentBlockControllers.Add(room);

        //Instantiate each room, bathrooms are always at the end
        int bathroomCountLabel = 1;
        for (int i = 0; i < componentSelectionController.houseConfig.rooms.Count; i++)
        {
            string label = (componentSelectionController.houseConfig.rooms.ElementAt(i).isBathroom) ? $"Bathroom {bathroomCountLabel++}" : $"Room {i}";
            room = RoomBuilder(label);
            room.components = componentSelectionController.houseConfig.rooms.ElementAt(i).components;
            allRoomComponentBlockControllers.Add(room);
        }

        RoomComponentBlockController RoomBuilder(string label)
        {
            GameObject g = Instantiate(prefab, instantiateLocation.transform);
            RoomComponentBlockController roomComponentBlockController = g.GetComponent<RoomComponentBlockController>();
            roomComponentBlockController.roomNameLabel.Text = label;
            return roomComponentBlockController;
        }
    }

    public void RedrawComponents()
    {
        foreach (RoomComponentBlockController t in allRoomComponentBlockControllers)
        {
            t.DrawComponentDetailsBlocks();
        }
    }
}
