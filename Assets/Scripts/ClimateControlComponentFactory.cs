using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class ClimateControlComponentFactory
{
    HouseConfig houseConfig;

    
    public ClimateControlComponent CreateComponentFromJsonFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file could not be found.");
        }

        string jsonString = File.ReadAllText(filePath);
        var component = JsonConvert.DeserializeObject<ClimateControlComponent>(jsonString);

        return component;
    }

    public string ConvertToJson(ClimateControlComponent component)
    {
        return JsonConvert.SerializeObject(component);
    }

    public void SetParentComponentsList(ClimateControlComponent childComponent, List<ClimateControlComponent> parentComponentsList)
    {
        if (childComponent != null && parentComponentsList != null)
            childComponent.parentComponentsList = parentComponentsList;
    }
}

