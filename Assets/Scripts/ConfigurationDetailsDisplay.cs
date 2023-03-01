using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConfigurationDetailsDisplay : MonoBehaviour
{
    public ClimateControlSystemConfig climateControlSystemConfig;
    public bool isPrimaryDisplay;

    [SerializeField] GameObject partCostRowPrefab;
    [SerializeField] Transform partCostRowLocation;
    [SerializeField] NovaExpandableContainer partCostExpandableContainer;

    public TextBlock ConfigName;
    public TextBlock TotalCosts;
    public TextBlock partsCostRange;

    private void Awake()
    {
        //if this is the primary display,
        //assign climateControlSystemConfig to config from ProgramManger

        CreateDummyConfig(); // remove this after testing
        DisplayConfig();
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

    private void DisplayConfig()
    {
        if (climateControlSystemConfig == null)
        {
            Debug.Log("ClimateControlSystemConfig is null");
            return;
        }

        PartsCost();

        CostCalculation costCalculation = new(climateControlSystemConfig);
        ConfigName.Text = climateControlSystemConfig.name;
        partsCostRange.Text = $"${costCalculation.partsCostLow} - ${costCalculation.partsCostHigh}";
    }

    private void PartsCost()
    {
        List<ClimateControlComponent> allComponents = new();
        allComponents.AddRange(climateControlSystemConfig.houseConfig.components);
        foreach (var item in climateControlSystemConfig.houseConfig.rooms)
        {
            allComponents.AddRange(item.components);
        }

        foreach (var item in allComponents)
        {
            GameObject g = Instantiate(partCostRowPrefab, partCostRowLocation);
            PartsCostRow row = g.GetComponent<PartsCostRow>();
            row.partName.Text = item.componentName;
            row.partPrice.Text = $"${item.priceRange.Item1} - ${item.priceRange.Item2}";
        }
        partCostExpandableContainer.Initialize();
    }
}
