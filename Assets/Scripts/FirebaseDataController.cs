using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Database;
using Google.MiniJSON;
using UnityEditor.VersionControl;
using UnityEngine;

public class FirebaseDataController : MonoBehaviour
{
    public DatabaseReference database;
    public FirebaseAuth auth;
    public ClimateControlSystemConfigFactory configFactory;

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
        RoomConfigs rooms = new RoomConfigs(new List<RoomConfig>());
        ClimateControlComponents components = new ClimateControlComponents(new List<ClimateControlComponent>());
        components.components.Add(new ClimateControlComponent("Generic AC", "description", "pros", "cons", ClimateControlComponentTypes.AirConditioner, false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric, (10f, 15f)));

        rooms.rooms.Add(new RoomConfig(components, 1, 1, false));

        HouseConfig houseConfig =new HouseConfig(rooms, components);
        UtilityConfig utilityConfig = new UtilityConfig(new UtilityRates(2, 2, 2, 2), 2);
        ClimateControlSystemConfig climateControlSystemConfig1 = new ClimateControlSystemConfig("ConfigTEST", houseConfig, utilityConfig);

        //StartCoroutine(SaveConfig(climateControlSystemConfig1));
        StartCoroutine(GetConfig("ConfigTEST"));

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
            yield return "Fail";
        }
        else
        {
            Debug.Log("INSIDE OF GETCONFIG");
            var dataSnapshot = DBTask.Result;
            Debug.Log($"dataSnapShot: {dataSnapshot.GetRawJsonValue()}");
            //var climateControlSystemConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(dataSnapshot.GetRawJsonValue());
            var climateControlSystemConfig = JsonUtility.FromJson<ClimateControlSystemConfig>(dataSnapshot.GetRawJsonValue());
            //HouseConfig houseConfig = configFactory.LoadHouseConfigFromJson(dataSnapshot);
            Debug.Log($"RESULT TESTTT: {climateControlSystemConfig.utilityConfig.zip}");
            Debug.Log($"OBJECT Count: {climateControlSystemConfig.houseConfig.components.components.Count}");
            Debug.Log($"OBJECT utilityRate: {climateControlSystemConfig.utilityConfig.utilityrates.GasPerTherm}");

            var test = "2";
            //Debug.Log(config.ToString());
            yield return climateControlSystemConfig;
        }
    }
    //public ClimateControlSystemConfig ConvertToSystemConfig(string name)
    //{
    //    var configs = GetConfig(name).Current.ToString();
    //    ClimateControlSystemConfig test = configFactory.LoadConfigFromJson(configs);
    //    Debug.Log(test.name);
    //    Debug.Log(test.houseConfig.components.ToString());

    //    return test;
    //}
    //public void TestReturnObject()
    //{
    //    var temp = ConvertToSystemConfig("Config1");
    //    //Debug.Log(ConvertToSystemConfig("climateControlSystemConfig1"));
    //}

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
