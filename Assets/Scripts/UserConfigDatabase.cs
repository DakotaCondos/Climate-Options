using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Auth;
using Newtonsoft.Json.Linq;


public class UserConfigDatabase : MonoBehaviour
{
    public DatabaseReference database;
    public FirebaseAuth auth;

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
        components.Add(new ClimateControlComponent("Generic AC", "description", "pros", "cons", new List<ClimateControlComponentTypes>(), false, false, true, 0f, 500f, 0f, 0.015f, ClimateControlComponentTypes.AirConditioner, UtilityType.Electric, (10f, 15f)));

        rooms.Add(new RoomConfig(components, 1, 1, false));

        InitializeFirebase();
        Debug.Log(auth.CurrentUser.UserId);
        HouseConfig houseConfig = new HouseConfig(rooms, components);
        UtilityConfig utilityConfig = new UtilityConfig();
        ClimateControlSystemConfig climateControlSystemConfig = new ClimateControlSystemConfig(houseConfig, utilityConfig);
        StartCoroutine(SaveConfig(auth.CurrentUser.UserId, climateControlSystemConfig));
    }
    public IEnumerator SaveConfig(string userID, ClimateControlSystemConfig climateControlSystemConfig)
    {
        var configAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(climateControlSystemConfig);
        Debug.Log(configAsJson);
        var DBTask = database.Child(userID).Child("ClimateControlSystemConfig").SetRawJsonValueAsync(configAsJson);
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if(DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to save data with {DBTask.Exception}");
        }
    }

    public IEnumerator GetConfig(string userID)
    {
        var DBTask = database.Child(userID).GetValueAsync();
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);
        if(DBTask.Exception != null)
        {
            Debug.LogWarning(message: "Fail");
        }
        else
        {
            DataSnapshot dataSnapshot = DBTask.Result;

        }
    }

}
