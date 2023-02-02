using Newtonsoft.Json;
using System.IO;

public class ClimateControlComponentFactory
{
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

    public void SetParentComponent(ClimateControlComponent childComponent, ClimateControlComponent parentComponent)
    {
        if (childComponent != null && parentComponent != null)
            childComponent.parentComponent = parentComponent;
    }
}

