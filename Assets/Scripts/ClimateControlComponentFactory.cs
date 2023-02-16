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

    public void SaveDummyComponent()
    {
        ClimateControlComponent component = new("Generic AC", "description", "pros", "cons", new List<ClimateControlComponentTypes>(), false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric, (10f, 15f));
        SaveObjectToJsonFile(component, component.componentName);
        components.Add(component);
        print("done");
    }

    public void LoadDummyComponent()
    {
        ClimateControlComponent component = LoadComponentFromJson("Generic AC");
        if (component != null) { components.Add(component); }
    }

    public ClimateControlComponent LoadComponentFromJson(string fileName)
    {
        string filePath = $"{jsonFileLocations}{fileName}.json";
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            ClimateControlComponent component = JsonUtility.FromJson<ClimateControlComponent>(json);
            return component;
        }
        else
        {
            Debug.LogError($"Failed to load component from {filePath}");
            return null;
        }
    }
}
