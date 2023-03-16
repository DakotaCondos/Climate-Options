#if UNITY_EDITOR
using System.Collections;
using UnityEngine;

public class ConfigurationDetailsController : MonoBehaviour
{
    public ConfigurationDetailsDisplay[] configurationDetailsDisplays;
    public ClimateData climateData;
    public bool isInitializingDisplay = false;
    public ProgramManager programManager;
    public GameObject SecondPanel;


    private void Awake()
    {
        climateData = FindObjectOfType<ClimateData>();
        programManager = FindObjectOfType<ProgramManager>();
        SecondPanel.SetActive(false);
    }

    private void Start()
    {
        InitailizeDisplay(configurationDetailsDisplays[0], programManager.climateControlSystemConfig);
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
        StartCoroutine(WaitForInitialDisplayLoadComplete());
    }

    private IEnumerator InitializeTracker(ConfigurationDetailsDisplay configurationDetailsDisplay)
    {
        while (configurationDetailsDisplay.loadingBlock.activeInHierarchy == true) { yield return null; }
        isInitializingDisplay = false;
    }

    private IEnumerator WaitForInitialDisplayLoadComplete()
    {
        while (isInitializingDisplay)
        {
            yield return null;
        }
        SecondPanel.SetActive(true);
    }
}
// current file contents
#endif