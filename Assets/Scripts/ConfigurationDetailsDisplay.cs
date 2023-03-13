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

    public TextBlock utilityElectricRate;
    public TextBlock utilityGasRate;
    public TextBlock utilityOilRate;
    public TextBlock utilityWoodRate;

    private void Awake()
    {
        //if this is the primary display,
        //assign climateControlSystemConfig to config from ProgramManger

        CreateDummyConfig(); // remove this after testing

        climateData = FindObjectOfType<ClimateData>();
    }

    public void Initialize(ClimateControlSystemConfig climateControlSystemConfig)
    {
        this.climateControlSystemConfig = climateControlSystemConfig;
        StartCoroutine(DisplayConfigCoroutine());
    }

    public void DevInitialize()
    {
        Initialize(CreateDummyConfig());
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

        //print debug logs
        foreach (var item in costCalculation.messages)
        {
            print(item);
        }
    }

    private ClimateControlSystemConfig CreateDummyConfig()
    {
        ClimateControlSystemConfig cl = new();
        cl.name = Guid.NewGuid().ToString();
        cl.houseConfig = new HouseConfig();
        cl.houseConfig.size = 1500;
        cl.houseConfig.components.Add(new ClimateControlComponent());
        cl.houseConfig.rooms.Add(new RoomConfig(0, false));
        cl.houseConfig.rooms.Add(new RoomConfig(1, false));
        cl.houseConfig.rooms.Add(new RoomConfig(2, false));
        cl.houseConfig.rooms.Add(new RoomConfig(3, true));
        cl.houseConfig.rooms.ForEach(r => { r.components.Add(new ClimateControlComponent()); });
        cl.utilityConfig = new(new UtilityRates(0.16f, 0.147f, 4.231f, 0.16f), 99004);
        return cl;
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
        TotalCosts.Text = $"${Decimal.Truncate(opCost + (decimal)costCalculation.partsCostLow)} - " +
            $"${Decimal.Truncate(opCost + (decimal)costCalculation.partsCostHigh)}";

        UtilInfo();
    }

    private void UtilInfo()
    {
        utilityElectricRate.Text = $"${climateControlSystemConfig.utilityConfig.utilityrates.electricityPerKWH}/KWH";
        utilityGasRate.Text = $"${climateControlSystemConfig.utilityConfig.utilityrates.gasPerTherm}/Therm";
        utilityOilRate.Text = $"${climateControlSystemConfig.utilityConfig.utilityrates.oilPerGallon}/Gallon";
        utilityWoodRate.Text = $"${climateControlSystemConfig.utilityConfig.utilityrates.woodPerPound}/Pound";
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
            row.textBlocks.ElementAt(1).Text = $"${item.priceLow} - ${item.priceHigh}";
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
            heatingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(1).Text = $"${(int)item.Item1}";

            GameObject coolingRow = Instantiate(partCostRowPrefab, operationCostRowLocation);
            coolingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(0).Text = $"{GetMonthName(currentMonth)} Cooling Costs";
            coolingRow.GetComponent<TextRowHelper>().textBlocks.ElementAt(1).Text = $"${(int)item.Item2}";

            currentMonth++;
        }
        operationCostExpandableContainer.Initialize();
    }
}
