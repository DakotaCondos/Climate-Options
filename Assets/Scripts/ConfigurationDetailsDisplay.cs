using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationDetailsDisplay : MonoBehaviour
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public bool isPrimaryDisplay;

    public TextBlock ConfigName;
    public TextBlock CostsCombined;
    public TextBlock partsRange;

    private void Awake()
    {
        //if this is the primary display,
        //assign climateControlSystemConfig to config from ProgramManger

        CreateDummyConfig(); // remove this after testing
    }

    private void CreateDummyConfig()
    {
        climateControlSystemConfig = new();
        climateControlSystemConfig.name = Guid.NewGuid().ToString();
        climateControlSystemConfig.houseConfig = new HouseConfig();
        climateControlSystemConfig.houseConfig.components.Add(new ClimateControlComponent());
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(0, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(1, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(2, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(3, true));
        climateControlSystemConfig.houseConfig.rooms.ForEach(r => { r.components.Add(new ClimateControlComponent()); });
        climateControlSystemConfig.utilityConfig = new();
    }

    private void Start()
    {
        DisplayConfig();
    }

    private void DisplayConfig()
    {
        if (climateControlSystemConfig == null)
        {
            Debug.Log("ClimateControlSystemConfig is null");
            return;
        }

        CostCalculation costCalculation = new(climateControlSystemConfig);
        ConfigName.Text = climateControlSystemConfig.name;
        partsRange.Text = $"Parts: ${costCalculation.partsCostLow} - ${costCalculation.partsCostHigh}";
    }
}
