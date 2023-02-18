using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nova;
using System;

public class ComponentSelectionController : MonoBehaviour
{
    public HouseConfig houseConfig;
    GameObject[] roomUIButtons;
    public List<ClimateControlComponent> componentListBeingEdited = null;
    [SerializeField]
    GameObject buttonPrefab;
    [SerializeField]
    GameObject instantiateRoomButttonLocation;

    [SerializeField]
    GameObject instantiateComponentButtonGroupLocation;
    [SerializeField]
    GameObject componentButtonGroupPrefab;

    public ProgramManager programManager;
    public int selectedComponentIndex;

    private void Awake()
    {

        programManager = FindObjectOfType<ProgramManager>();
        selectedComponentIndex = -1;


        // ---------------- Demo house only DELETE ------------------
        houseConfig = new();
        for (int i = 0; i < 8; i++)
        {
            houseConfig.rooms.Add(new RoomConfig(i, (i > 5)));
        }
        // ---------------------------------------------------------


        CreateRoomButtons();
        CreateComponentButtons();

    }

    private void CreateComponentButtons()
    {
        //for now just create a button for every component
        for (int i = 0; i < programManager.components.Count; i++)
        {
            GameObject buttongroup = Instantiate(componentButtonGroupPrefab, instantiateComponentButtonGroupLocation.transform);
            ComponentButton componentButton = buttongroup.GetComponent<ComponentButtonRowHelper>().componentButton.GetComponent<ComponentButton>();
            componentButton.component = programManager.components[i];
            ComponentInfoButton componentInfoButton = buttongroup.GetComponent<ComponentButtonRowHelper>().infoButton.GetComponent<ComponentInfoButton>();
            componentInfoButton.component = programManager.components[i];
        }
    }

    private void CreateRoomButtons()
    {
        //Instantiate and assign buttons for each room
        roomUIButtons = new GameObject[houseConfig.rooms.Count];
        int bathroomCountLabel = 1;
        for (int i = 0; i < roomUIButtons.Length; i++)
        {
            GameObject g = Instantiate(buttonPrefab, instantiateRoomButttonLocation.transform);

            //set RoomHelper reference to room in house
            g.GetComponent<RoomHelper>().componentsList = houseConfig.GetRoomByID(i).components;

            //set TextBlock text
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
}
