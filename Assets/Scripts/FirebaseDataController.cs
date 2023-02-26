using System.Collections;
using System.Collections.Generic;
using Firebase.Auth;
using Firebase.Database;
using UnityEngine;
using Newtonsoft.Json.Linq;

public class FirebaseDataController : MonoBehaviour
{
    public DatabaseReference database;
    public FirebaseAuth auth;

    public ClimateControlSystemConfigFactory testConfigFactory;
    public ClimateControlSystemConfig saveConfig;

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
        List<ClimateControlComponent> components = new List<ClimateControlComponent>
        {
            new ClimateControlComponent("Generic AC", "description", "pros", "cons", ClimateControlComponentTypes.AirConditioner, false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric, (10f, 15f))
        };

        rooms.Add(new RoomConfig(components, 1, 1, false));

        InitializeFirebase();
        Debug.Log(auth.CurrentUser.UserId);
        HouseConfig houseConfig = gameObject.AddComponent<HouseConfig>();
        UtilityConfig utilityConfig = new UtilityConfig(new UtilityRates(2, 2, 2, 2), 2);
        ClimateControlSystemConfig climateControlSystemConfig1 = new ClimateControlSystemConfig("Config1", houseConfig, utilityConfig);
        ClimateControlSystemConfig climateControlSystemConfig2 = new ClimateControlSystemConfig("Config2", houseConfig, utilityConfig);
        StartCoroutine(SaveConfig(climateControlSystemConfig1));
        //StartCoroutine(SaveConfig(climateControlSystemConfig2));
        //StartCoroutine(GetConfig(climateControlSystemConfig1.name));
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
        }
        else
        {
            Debug.Log("Inside of GetConfig. Start of else statement.");
            var rawSnapShot = DBTask.Result;
            Debug.Log($"RawSnapShot{rawSnapShot.ToString()}");
            var dataSnapshot = DBTask.Result.GetRawJsonValue();
            Debug.Log(dataSnapshot);
            saveConfig = testConfigFactory.LoadConfigFromJson(dataSnapshot);
            var test = "test";
            //Debug.Log(saveConfig.name);
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
