using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIController : MonoBehaviour
{
    public float delayTime = 2f;

    public void OnSuccess()
    {
        StartCoroutine(PerformDelayedAction());
    }

    IEnumerator PerformDelayedAction()
    {
        yield return new WaitForSeconds(delayTime);
        print("reached!");
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        FindObjectOfType<ProgramManagerController>().LoadSceneName("HouseScene");
    }
}
