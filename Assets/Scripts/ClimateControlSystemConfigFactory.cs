using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateControlSystemConfigFactory : MonoBehaviour
{
    public ClimateControlSystemConfig systemConfig;

    public void Awake()
    {
        systemConfig = new ClimateControlSystemConfig();
    }
    public ClimateControlSystemConfig LoadConfigFromJson(string json)
    {

        if (!string.IsNullOrEmpty(json))
        {
            Debug.Log("Inside of factory if statement.");
            systemConfig = JsonUtility.FromJson<ClimateControlSystemConfig>(json);
            return systemConfig;
        }
        else
        {
            Debug.Log("Inside of factory else statement.");
            Debug.LogError($"Fail");
            return null;
        }
    }
}
