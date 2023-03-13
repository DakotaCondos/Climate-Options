using Nova;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class SavePanelController : MonoBehaviour
{
    public TextBlock saveName;
    public TextBlock responseBlock;
    FirebaseDataController firebaseDataController;
    ProgramManager programManager;
    public bool hasStartedSave = false;
    public bool hasFinishedSave = false;

    private void Awake()
    {
        firebaseDataController = FindObjectOfType<FirebaseDataController>();
        programManager = FindObjectOfType<ProgramManager>();
    }

    public void Save()
    {
        if (hasFinishedSave)
        {
            UpdateResponse($"Saved Successfully as: {programManager.climateControlSystemConfig.name}", Color.green);
            return;
        }
        else if (hasStartedSave)
        {
            UpdateResponse($"Saving in progress", Color.yellow);
            return;
        }

        //print($"Has Invalid: {HasInvalidRealtimeDatabaseNameCharacters()}");

        if (HasInvalidRealtimeDatabaseNameCharacters())
        {
            UpdateResponse("Invalid Name", Color.red);
            return;
        }
        StartCoroutine(SaveCoroutine());
    }

    private IEnumerator SaveCoroutine()
    {
        hasStartedSave = true;
        AsyncRequestHelper helper = new();
        programManager.climateControlSystemConfig.name = saveName.Text;
        firebaseDataController.SaveClimateControlSystemConfig(programManager.climateControlSystemConfig, helper);
        while (helper.isProcessing)
        {
            yield return null;
        }
        hasFinishedSave = true;
        UpdateResponse("Saved Successfully", Color.green);
    }

    private bool HasInvalidRealtimeDatabaseNameCharacters()
    {
        if (string.IsNullOrEmpty(saveName.Text)) return true;
        string pattern = @"[.$#\[\]/]";
        Regex regex = new(pattern);
        return regex.IsMatch(saveName.Text);
    }

    private void UpdateResponse(string message, Color color)
    {
        responseBlock.Text = message;
        responseBlock.Color = color;
    }
}
