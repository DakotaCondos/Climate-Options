using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateControlSystemConfigFactory : MonoBehaviour
{

    public ClimateControlSystemConfig LoadConfigFromJson(string json)
    {

        if (!string.IsNullOrEmpty(json))
        {
            Debug.Log("Inside of factory if statement.");
            ClimateControlSystemConfig systemConfigs = JsonUtility.FromJson<ClimateControlSystemConfig>(json);
            return systemConfigs;
        }
        else
        {
            Debug.Log("Inside of factory else statement.");
            Debug.LogError($"Fail");
            return null;
        }
    }
}
