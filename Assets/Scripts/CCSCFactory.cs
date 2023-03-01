using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEditor.Progress;

public class CCSCFactory : MonoBehaviour
{

    readonly string fileLocation = $"{Application.streamingAssetsPath}/Systems/";
    public List<ClimateControlSystemConfig> systems;


    private void Awake()
    {
        systems = new List<ClimateControlSystemConfig>();
    }

    public void SaveObjectToJsonFile(object objectToSave, string fileName)
    {
        string json = JsonUtility.ToJson(objectToSave);
        File.WriteAllText($"{fileLocation}{fileName}.json", json);
    }

    public void TestingSave()
    {
        foreach (ClimateControlSystemConfig item in systems)
        {
            string json = JsonUtility.ToJson(item);
            File.WriteAllText($"{fileLocation}{item.name}.json", json);
        }
    }

    public ClimateControlSystemConfig LoadSystemFromJson(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            ClimateControlSystemConfig systemConfig = JsonUtility.FromJson<ClimateControlSystemConfig>(json);
            return systemConfig;
        }
        else
        {
            Debug.LogError($"Failed to load ClimateControlSystemConfig from {fileName}");
            return null;
        }
    }

    public void ProcessJsonFiles()
    {
        string[] fileNames = Directory.GetFiles(fileLocation, "*.json");

        foreach (string fileName in fileNames)
        {
            ClimateControlSystemConfig systemConfig = LoadSystemFromJson(fileName);
            if (systemConfig != null)
            {
                systems.Add(systemConfig);
            }
            else
            {
                Debug.Log($"SYSTEM CREATION FAILURE OF FILE {fileName}");
            }
        }
    }

    public void CreateDummyCCSC()
    {
        ClimateControlSystemConfig systemConfig = new();
        systemConfig.name = $"{Time.time}";
        systemConfig.houseConfig = new HouseConfig();
        systemConfig.houseConfig.components.Add(new ClimateControlComponent());
        systemConfig.houseConfig.rooms.Add(new RoomConfig(0, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(1, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(2, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(3, true));
        systemConfig.houseConfig.rooms.ForEach(r => { r.components.Add(new ClimateControlComponent()); });

        systemConfig.utilityConfig = new();

        systems.Add(systemConfig);
    }
}


