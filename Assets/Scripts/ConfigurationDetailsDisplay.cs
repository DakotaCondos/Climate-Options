using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ConfigurationDetailsDisplay : MonoBehaviour
{
    public GameObject loadingBlock;

    public ClimateControlSystemConfig climateControlSystemConfig;
    public bool isPrimaryDisplay;
    public ClimateData climateData;
    public CostCalculation costCalculation;

    [SerializeField] GameObject partCostRowPrefab;
    [SerializeField] Transform partCostRowLocation;
    [SerializeField] NovaExpandableContainer partCostExpandableContainer;

    [SerializeField] Transform operationCostRowLocation;
    [SerializeField] NovaExpandableContainer operationCostExpandableContainer;

    public TextBlock ConfigName;
    public TextBlock TotalCosts;
    public TextBlock partsCostRange;

    public TextBlock OperationCostTotal;

    private void Awake()
    {
        //if this is the primary display,
        //assign climateControlSystemConfig to config from ProgramManger

        CreateDummyConfig(); // remove this after testing

        climateData = FindObjectOfType<ClimateData>();
    }

    private void Start()
    {
        StartCoroutine(DisplayConfigCoroutine());
    }

    public IEnumerator DisplayConfigCoroutine()
    {
        loadingBlock.SetActive(true);
        //wait for climate data to be ready
        while (!climateData.isDataReady)
        {
            yield return null;
        }
        DisplayConfig();
        loadingBlock.SetActive(false);
    }

    private void CreateDummyConfig()
    {
        climateControlSystemConfig = new();
        climateControlSystemConfig.name = Guid.NewGuid().ToString();
        climateControlSystemConfig.houseConfig = new HouseConfig();
        climateControlSystemConfig.houseConfig.size = 1500;
        climateControlSystemConfig.houseConfig.components.Add(new ClimateControlComponent());
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(0, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(1, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(2, false));
        climateControlSystemConfig.houseConfig.rooms.Add(new RoomConfig(3, true));
        climateControlSystemConfig.houseConfig.rooms.ForEach(r => { r.components.Add(new ClimateControlComponent()); });
        climateControlSystemConfig.utilityConfig = new(new UtilityRates(0.23f, 0.147f, 4.231f, 0.16f), 99004);

    }

    private void DisplayConfig()
    {
        if (climateControlSystemConfig == null)
        {
            Debug.Log("ClimateControlSystemConfig is null");
            return;
        }

        PartsCost();

        costCalculation = new(climateControlSystemConfig, climateData.climateDataMonths);
        //costCalculation = gameObject.AddComponent<CostCalculation>();
        //costCalculation.climateControlSystemConfig = climateControlSystemConfig;
        //costCalculation.climateDataMonths = climateData.climateDataMonths;
        //costCalculation.Initialize();


        ConfigName.Text = climateControlSystemConfig.name;
        partsCostRange.Text = $"${costCalculation.partsCostLow} - ${costCalculation.partsCostHigh}";

        OperationCost();
        decimal opCost = 0;
        foreach ((decimal, decimal) month in costCalculation.monthlyOperationCosts)
        {
            opCost += month.Item1 + month.Item2;
        }
        OperationCostTotal.Text = $"${Decimal.Truncate(opCost)}";

    }

    public static string GetMonthName(int monthNumber)
    {
        DateTime date = new(1, monthNumber, 1);
        return date.ToString("MMMM");
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
            TextRowHelper row = g.GetComponent<TextRowHelper>();
            row.textBlocks.ElementAt(0).Text = item.componentName;
            row.textBlocks.ElementAt(1).Text = $"${item.priceRange.Item1} - ${item.priceRange.Item2}";
        }
        partCostExpandableContainer.Initialize();
    }

    private void OperationCost()
    {
        int currentMonth = 1;
        foreach (var item in costCalculation.monthlyOperationCosts)
        {
            GameObject heatingRow = Instantiate(partCostRowPrefab, operationCostRowLocation);
            heatingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(0).Text = $"{GetMonthName(currentMonth)} Heating Costs";
            heatingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(1).Text = $"${Decimal.Truncate(item.Item1)}";

            GameObject coolingRow = Instantiate(partCostRowPrefab, operationCostRowLocation);
            coolingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(0).Text = $"{GetMonthName(currentMonth)} Cooling Costs";
            coolingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(1).Text = $"${Decimal.Truncate(item.Item2)}";

            currentMonth++;
        }
        operationCostExpandableContainer.Initialize();
    }
}
