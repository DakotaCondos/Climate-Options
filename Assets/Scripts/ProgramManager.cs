using Nova;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProgramManager : MonoBehaviour
{
    [SerializeField] string componentsFilePath = $"{Application.streamingAssetsPath}/Components/";
    [SerializeField] TextBlock loadingActionText;
    public List<ClimateControlComponent> components = new List<ClimateControlComponent>();
    public ClimateControlComponentFactory factory;
    public SceneController sceneController;


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

        factory = GetComponent<ClimateControlComponentFactory>();
        sceneController = GetComponent<SceneController>();
        ProcessJsonFiles();
    }

    private void Start()
    {
        OnLoadingComplete();
    }

    private void OnLoadingComplete()
    {
        sceneController.LoadSceneName("HomeScene_dakota");
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
                Debug.Log($"Processed file {fileName}");
            }
            else
            {
                Debug.Log($"PROCESS FAILURE of file {fileName}");

            }
        }
    }
}
