using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProgramManager : MonoBehaviour
{
    [SerializeField] string componentsFilePath;
    [SerializeField] TextBlock loadingActionText;
    public List<ClimateControlComponent> components = new();
    public ClimateControlComponentFactory factory;
    public SceneController sceneController;
    public ClimateControlSystemConfig climateControlSystemConfig;
    public UtilityRatesAndZip utilityRatesAndZip;

    public bool isComponentsReady = false;


    private static ProgramManager instance;
    public static ProgramManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ProgramManager>();
            }
            return instance;
        }
    }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        componentsFilePath = $"{Application.streamingAssetsPath}/Components/";
        factory = GetComponent<ClimateControlComponentFactory>();
        sceneController = GetComponent<SceneController>();
        utilityRatesAndZip = GetComponent<UtilityRatesAndZip>();
        climateControlSystemConfig = new();
        StartCoroutine(LoadingSequence());
    }

    public IEnumerator LoadingSequence()
    {
        ProcessJsonFiles();
        while (!isComponentsReady || !utilityRatesAndZip.isReady)
        {
            yield return null;
        }


        OnLoadingComplete();
    }

    private void OnLoadingComplete()
    {
        sceneController.LoadSceneName("HomeScene");
    }

    void ProcessJsonFiles()
    {
        string[] fileNames = Directory.GetFiles(componentsFilePath, "*.json");

        foreach (string fileName in fileNames)
        {
            if (loadingActionText != null)
            {
                loadingActionText.Text = $"Creating Component from {fileName}";
            }

            ClimateControlComponent component = factory.LoadComponentFromJson(fileName);
            if (component != null)
            {
                components.Add(component);
            }
            else
            {
                Debug.Log($"COMPONENT CREATION FAILURE OF FILE {fileName}");

            }
        }

        isComponentsReady = true;
    }

    public void ResetClimateControlSystemConfig()
    {
        this.climateControlSystemConfig = new();
    }


}
