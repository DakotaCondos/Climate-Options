using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramManagerController : MonoBehaviour
{
    public ProgramManager programManager;

    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
        if (programManager == null)
        {
            Debug.Log("ProgramManagerController could not find ProgramManager in Scene");
        }
    }

    public void LoadSceneName(string sceneName)
    {
        programManager.sceneController.LoadSceneName(sceneName);
    }
    public void LoadSceneIndex(int sceneIndex)
    {
        programManager.sceneController.LoadSceneIndex(sceneIndex);
    }
    public void QuitGame()
    {
        programManager.sceneController.QuitGame();
    }
}
