using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nova;

public class ComponentSelectionController : MonoBehaviour
{
    public HouseConfig houseConfig;
    GameObject[] roomUIButtons;
    [SerializeField]
    GameObject buttonPrefab;
    [SerializeField]
    GameObject instantiateLocation;

    private void Awake()
    {

        //to-do
        //load HouseConfig from persistent data source


        // ---------------- Demo house only DELETE ------------------
        houseConfig = new();
        for (int i = 0; i < 8; i++)
        {
            houseConfig.rooms.Add(new RoomConfig(i, (i > 5)));
        }
        // ---------------------------------------------------------


        //Instantiate and assign buttons for each room
        roomUIButtons = new GameObject[houseConfig.rooms.Count];
        int bathroomCountLabel = 1;
        for (int i = 0; i < roomUIButtons.Length; i++)
        {
            GameObject g = Instantiate(buttonPrefab, instantiateLocation.transform);
            var textBlock = g.GetComponentInChildren<TextBlock>();
            if (textBlock != null)
            {
                string labelText = "";
                if (houseConfig.GetRoomByID(i).isBathroom)
                {
                    labelText = $"Bathroom {bathroomCountLabel++}";
                }
                else
                {
                    labelText = $"Room {i}";
                }
                textBlock.Text = labelText;
            }
            else
            {
                Debug.Log("Could not find TextBlock!");
            }
            roomUIButtons[i] = g;
        }

    }

    [ContextMenu("Load Rooms")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
}
