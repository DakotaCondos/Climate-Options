using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationDetailsDisplay : MonoBehaviour
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public TextBlock ConfigName;
    public TextBlock CostsCombined;
    public TextBlock partsRange;

    private void Awake()
    {
        CreateDummyConfig(); // remove this after testing
    }

    private void CreateDummyConfig()
    {
        climateControlSystemConfig = new()
        {
            name = "Demo ClimateControlSystemConfig",
            houseConfig = new()
        };
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
        partsRange.Text = $"${costCalculation.partsCostLow} - {costCalculation.partsCostHigh}";
    }
}
