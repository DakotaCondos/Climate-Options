using System.Collections;
using System.Collections.Generic;
using Firebase.Auth;
using Firebase.Database;
using Google.MiniJSON;
using UnityEngine;

public class FirebaseDataController : MonoBehaviour
{
    public DatabaseReference database;
    public FirebaseAuth auth;
    //public ClimateControlSystemConfigFactory systemConfigFactory;
    UtilRateLookup utilRateLookup = new UtilRateLookup();

    void Awake()
    {
        InitializeFirebase();
    }
    private void InitializeFirebase()
    {
        auth = FirebaseAuth.DefaultInstance;
        database = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void seed()
    {
        
        List<RoomConfig> rooms = new List<RoomConfig>();
        List<ClimateControlComponent> components = new List<ClimateControlComponent>();
        components.Add(new ClimateControlComponent("Generic AC", "description", "pros", "cons", ClimateControlComponentTypes.AirConditioner, false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric, (10f, 15f)));

        rooms.Add(new RoomConfig(components, 1, 1, false));

        InitializeFirebase();
        Debug.Log(auth.CurrentUser.UserId);
        HouseConfig houseConfig =new HouseConfig(rooms, components);
        UtilityConfig utilityConfig = utilRateLookup.FindByZipcode(20);
        //UtilityConfig utilityConfig = new UtilityConfig(new UtilityRates(2, 2, 2, 2), 2);
        //Debug.Log(Newtonsoft.Json.JsonConvert.SerializeObject(utilityConfig));
        ClimateControlSystemConfig climateControlSystemConfig1 = new ClimateControlSystemConfig("ConfigTEST", houseConfig, utilityConfig);
        //ClimateControlSystemConfig climateControlSystemConfig2 = new ClimateControlSystemConfig("Config2", houseConfig, utilityConfig);

        //StartCoroutine(SaveConfig(climateControlSystemConfig1));

        StartCoroutine(GetConfig("ConfigTEST"));
        //LoadAllConfigName();
    }
    public IEnumerator SaveConfig(ClimateControlSystemConfig climateControlSystemConfig)
    {
        var configAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(climateControlSystemConfig);
        //var configAsJson = JsonUtility.ToJson(climateControlSystemConfig);
        Debug.Log(configAsJson);
        var DBTask = database.Child(auth.CurrentUser.UserId).Child(climateControlSystemConfig.name).SetRawJsonValueAsync(configAsJson);
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to save data with {DBTask.Exception}");
        }
    }

    public IEnumerator GetConfig(string name)
    {
        var DBTask = database.Child(auth.CurrentUser.UserId).Child(name).GetValueAsync();
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);
        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: "Fail");
            yield return "FAIL";
        }
        else
        {
            var dataSnapshot = DBTask.Result.GetRawJsonValue();
            ClimateControlSystemConfig systemConfigs = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(dataSnapshot);
            //ClimateControlSystemConfig systemConfigs = systemConfigFactory.LoadConfigFromJson(dataSnapshot);
            //Debug.Log(systemConfigs.utilityConfig.utilityrates.ElectricityPerKWH);
            Debug.Log(systemConfigs.houseConfig.components[0].componentName);
            yield return systemConfigs;
        }
    }

    public List<string> LoadAllConfigName()
    {
        List<string> savedConfigNames = new List<string>();
        var DBTask = database.Child(auth.CurrentUser.UserId).GetValueAsync();
        DataSnapshot dataSnapshot = DBTask.Result;
        if(dataSnapshot.Exists)
        {
            foreach (var config in dataSnapshot.Children)
            {
                savedConfigNames.Add(config.Key);
                Debug.Log(config.Key);
            }
        }
        else {
            Debug.LogWarning(message: "Fail");
        }
        return savedConfigNames;
    }
}
