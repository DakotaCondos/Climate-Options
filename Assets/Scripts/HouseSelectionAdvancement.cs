using NovaSamples.UIControls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSelectionAdvancement : MonoBehaviour
{
    ProgramManager programManager;
    HouseController houseController;
    FirebaseStorageController firebaseStorageController;
    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
        houseController = FindObjectOfType<HouseController>();
        firebaseStorageController = FindObjectOfType<FirebaseStorageController>();

        if (houseController == null) Debug.LogError("HouseController could not be found");
        if (programManager == null) Debug.LogError("ProgramManager could not be found");


    }

    public void OnNextSceneAdvance()
    {
        HouseConfig houseConfig = houseController.houseConfig;
        List<string> guidValues = firebaseStorageController.guidValues;

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
        programManager.climateControlSystemConfig.pictureNames = guidValues;
        programManager.sceneController.LoadSceneName("SetupScene");
    }
}
