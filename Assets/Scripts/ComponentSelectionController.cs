using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nova;
using System;
using System.Linq;

public class ComponentSelectionController : MonoBehaviour
{
    public HouseConfig houseConfig;
    [SerializeField] GameObject[] roomUIButtons;
    [SerializeField] List<GameObject> componentButtonGroups = new();
    public List<ClimateControlComponent> componentListBeingEdited = null;
    [SerializeField]
    GameObject buttonPrefab;
    [SerializeField]
    GameObject instantiateRoomButttonLocation;

    [SerializeField]
    GameObject instantiateComponentButtonGroupLocation;
    [SerializeField]
    GameObject componentButtonGroupPrefab;
    [SerializeField] TextBlock componentsHeaderLabel;



    public ProgramManager programManager;
    public int selectedComponentIndex;

    private void Awake()
    {

        programManager = FindObjectOfType<ProgramManager>();
        selectedComponentIndex = -1;


        // ---------------- Demo house only DELETE ------------------
        GameObject g = new();
        g.AddComponent<HouseConfig>();
        houseConfig = g.GetComponent<HouseConfig>();
        for (int i = 0; i < 8; i++)
        {
            houseConfig.rooms.Add(new RoomConfig(i, (i > 5)));
        }
        // ---------------------------------------------------------


        CreateRoomButtons();
    }

    private void Start()
    {
        UpdateComponentsDisplay(true);
        componentListBeingEdited = houseConfig.components;
    }

    public void UpdateComponentHeaderLabel(string roomDisplayName)
    {
        if (roomDisplayName != null)
        {
            componentsHeaderLabel.Text = $"Components for {roomDisplayName}";
        }
    }

    public void UpdateComponentsDisplay(bool isWholeHomeButton)
    {
        List<ClimateControlComponent> returnList;
        List<ClimateControlComponent> enumerationList;
        if (isWholeHomeButton)
        {
            returnList = programManager.components.Where(s => s.isWholeHomeComponent == true).ToList();
        }
        else
        {
            enumerationList = programManager.components.Where(s => s.isWholeHomeComponent == false).ToList();
            returnList = new(enumerationList);
            foreach (var searchComponent in enumerationList)
            {
                if (searchComponent.prerequisiteComponentType == ClimateControlComponentTypes.None) { continue; }

                bool shouldPrune = true;
                foreach (var houseLevelComponent in houseConfig.components)
                {
                    if (searchComponent.prerequisiteComponentType == houseLevelComponent.componentType)
                    {
                        shouldPrune = false;
                        break;
                    }
                }

                if (shouldPrune)
                {
                    returnList.Remove(searchComponent);
                }
            }
        }
        CreateComponentButtons(returnList);
    }


    private void CreateComponentButtons(List<ClimateControlComponent> componentListArg)
    {
        //Clear Current Component Buttons From Screen
        foreach (var item in componentButtonGroups)
        {
            Destroy(item);
        }
        componentButtonGroups.Clear();

        //create a button for every component in list arg
        for (int i = 0; i < componentListArg.Count; i++)
        {
            GameObject buttongroup = Instantiate(componentButtonGroupPrefab, instantiateComponentButtonGroupLocation.transform);
            componentButtonGroups.Add(buttongroup);
            ComponentButton componentButton = buttongroup.GetComponent<ComponentButtonRowHelper>().componentButton.GetComponent<ComponentButton>();
            componentButton.component = componentListArg[i];
            ComponentInfoButton componentInfoButton = buttongroup.GetComponent<ComponentButtonRowHelper>().infoButton.GetComponent<ComponentInfoButton>();
            componentInfoButton.component = componentListArg[i];
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
                g.GetComponent<RoomHelper>().areaDisplayName = labelText;
            }
            else
            {
                Debug.Log("Could not find TextBlock!");
            }
            roomUIButtons[i] = g;
        }
    }

    public void OnNext()
    {
        //grab all component Lists for various rooms and add them to the House.
    }
}
