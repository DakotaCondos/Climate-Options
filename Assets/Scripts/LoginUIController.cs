//#if UNITY_EDITOR
using System.Collections;
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
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        FindObjectOfType<ProgramManagerController>().LoadSceneName("HouseScene");
    }
}
// current file contents
//#endif