using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void LoadSceneName(string sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName) != null)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log($"Scene {sceneName} could not be found!");
        }
    }

    public void LoadSceneIndex(int sceneIndex)
    {
        if (SceneManager.GetSceneByBuildIndex(sceneIndex) != null)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.Log($"Scene {sceneIndex} could not be found!");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }

    public void DelayLoadScene(float delayTime, string sceneName)
    {
        StartCoroutine(DelayActionLoadScene(delayTime, sceneName));
    }

    IEnumerator DelayActionLoadScene(float delayTime, string sceneName)
    {
        yield return new WaitForSeconds(delayTime);

        LoadSceneName(sceneName);
    }
}
