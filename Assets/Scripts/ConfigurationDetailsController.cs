using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationDetailsController : MonoBehaviour
{
    public ConfigurationDetailsDisplay[] ConfigurationDetailsDisplays;
    ClimateData climateData;
    bool isInitializingDisplay = false;


    private void Awake()
    {
        climateData = FindObjectOfType<ClimateData>();
    }

    public void InitailizeDisplay(ConfigurationDetailsDisplay configurationDetailsDisplay, ClimateControlSystemConfig climateControlSystemConfig)
    {
        //ClimateData can only hold 1 set of information at a time. Ensure no duplicate/overwriting calls are made from here
        if (isInitializingDisplay) return;

        isInitializingDisplay = true;
        //start climate data on retrieving data for system zip
        climateData.GetYearClimateData(climateControlSystemConfig.utilityConfig.zip);
        configurationDetailsDisplay.Initialize(climateControlSystemConfig);

        StartCoroutine(InitializeTracker(configurationDetailsDisplay));
    }

    private IEnumerator InitializeTracker(ConfigurationDetailsDisplay configurationDetailsDisplay)
    {
        while (configurationDetailsDisplay.loadingBlock.activeInHierarchy == true) { yield return null; }
        isInitializingDisplay = false;
    }
}
