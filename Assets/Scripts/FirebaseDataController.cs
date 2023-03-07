using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Database;
using Google.MiniJSON;
using Newtonsoft.Json;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class FirebaseDataController : MonoBehaviour
{
    public DatabaseReference database;
    public FirebaseAuth auth;
    

    private void Start()
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
        ClimateControlSystemConfig systemConfig = new();
        
        systemConfig.name = $"TestingConfig";
        systemConfig.houseConfig = new HouseConfig();
        systemConfig.houseConfig.components.Add(new ClimateControlComponent());
        systemConfig.houseConfig.rooms.Add(new RoomConfig(0, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(1, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(2, false));
        systemConfig.houseConfig.rooms.Add(new RoomConfig(3, true));
        systemConfig.houseConfig.rooms.ForEach(r => { r.components.Add(new ClimateControlComponent()); });

        systemConfig.utilityConfig = new();
        StartCoroutine(SaveConfig(systemConfig));
        print("Reached end");
    }

    public void ShowDetails()
    {
        print($"Current user: {auth.CurrentUser.UserId}");
        print($"Database is null: {database is null}");
    }

    public void SaveClimateControlSystemConfig(ClimateControlSystemConfig climateControlSystemConfig)
    {
        StartCoroutine(SaveConfig(climateControlSystemConfig));
    }

    public IEnumerator SaveConfig(ClimateControlSystemConfig climateControlSystemConfig)
    {
        var configAsJson = JsonUtility.ToJson(climateControlSystemConfig);
        var DBTask = database.Child(auth.CurrentUser.UserId).Child(climateControlSystemConfig.name).SetRawJsonValueAsync(configAsJson);
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to save data with {DBTask.Exception}");
        }
    }

    public async Task<ClimateControlSystemConfig> GetConfig(string name)
    {
        var DBTask = await database.Child(auth.CurrentUser.UserId).Child(name).GetValueAsync();

        var dataSnapshot = DBTask.GetRawJsonValue();
        ClimateControlSystemConfig systemConfigs = JsonUtility.FromJson<ClimateControlSystemConfig>(dataSnapshot);
        return systemConfigs;
    }

    public async void AddSystemsToList(List<ClimateControlSystemConfig> list)
    {
        List<string> systemNames = await GetAllChildNames();
        foreach (var item in systemNames)
        {
            ClimateControlSystemConfig climateControlSystemConfig = await GetConfig(item);
            if (climateControlSystemConfig != null) list.Add(climateControlSystemConfig);
        }
        print("Done with AddSystemsToList");
    }

    public async Task<List<string>> GetAllChildNames()
    {
        List<string> childNames = new();
        var DBTask = await database.Child(auth.CurrentUser.UserId).GetValueAsync();

        var dataSnapshot = DBTask.GetRawJsonValue();
        if (dataSnapshot != null)
        {
            Dictionary<string, object> dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(dataSnapshot);

            foreach (var item in dict)
            {
                childNames.Add(item.Key);
            }
        }

        return childNames;
    }
}
