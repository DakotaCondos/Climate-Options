using NovaSamples.UIControls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSelectionAdvancement : MonoBehaviour
{
    ProgramManager programManager;
    HouseController houseController;
    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
        houseController = FindObjectOfType<HouseController>();

        if (houseController == null) Debug.LogError("HouseController could not be found");
        if (programManager == null) Debug.LogError("ProgramManager could not be found");


    }

    public void OnNextSceneAdvance()
    {
        HouseConfig houseConfig = houseController.houseConfig;

        if (houseConfig == null)
        {
            Debug.LogError("houseController.houseConfig object is null");
            return;
        }

        if (programManager.climateControlSystemConfig == null)
        {
            programManager.climateControlSystemConfig = new();
        }

        programManager.climateControlSystemConfig.houseConfig = houseConfig;
        programManager.sceneController.LoadSceneName("SetupScene");
    }
}
