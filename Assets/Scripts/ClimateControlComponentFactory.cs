using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ClimateControlComponentFactory : MonoBehaviour
{
    readonly string jsonFileLocations = $"{Application.streamingAssetsPath}/Components/";
    public List<ClimateControlComponent> components;

    private void Awake()
    {
        components = new List<ClimateControlComponent>();
    }

    public void SaveObjectToJsonFile(object objectToSave, string fileName)
    {
        string json = JsonUtility.ToJson(objectToSave);
        File.WriteAllText($"{jsonFileLocations}{fileName}.json", json);
    }

    public ClimateControlComponent LoadComponentFromJson(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            ClimateControlComponent component = JsonUtility.FromJson<ClimateControlComponent>(json);
            return component;
        }
        else
        {
            Debug.LogError($"Failed to load component from {fileName}");
            return null;
        }
    }
}
