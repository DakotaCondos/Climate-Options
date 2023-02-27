using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Google.MiniJSON;

public class ClimateControlSystemConfigFactory
{

    public ClimateControlSystemConfig LoadConfigFromJson(DataSnapshot json)
    {

        if (!string.IsNullOrEmpty(json.Key))
        {
            Debug.Log("Inside of factory if statement.");
            //var listRoomConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RoomConfig>>(json.Child("houseConfig").Child("rooms").GetRawJsonValue());
            //var listComponent = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClimateControlComponent>>(json.Child("houseConfig").Child("components").GetRawJsonValue());
            //var houseConfig = new HouseConfig(listRoomConfig, listComponent);

            //var utilityConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<UtilityConfig>(json.Child("utilityConfig").GetRawJsonValue());

            //var climateControlSystemConfig = new ClimateControlSystemConfig("Config1", houseConfig, utilityConfig);
            var climateControlSystemConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(json.GetRawJsonValue());
            //ClimateControlSystemConfig systemConfigs = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(json)
            return climateControlSystemConfig;

        }
        else
        {
            Debug.Log("Inside of factory else statement.");
            Debug.LogError($"Fail");
            return null;
        }
    }

    //public ClimateControlSystemConfig LoadConfigFromJson(DataSnapshot json)
    //{


    //    //Debug.Log("Inside of factory if statement.");
    //    //var houseConfig = LoadHouseConfigFromJson(json.Child("houseConfig"));
    //    //var utilityConfig = LoadUtilityFromJson(json.Child("utilityConfig"));
    //    //var name = json.Child("name").Value.ToString();
    //    //ClimateControlSystemConfig systemConfig = new ClimateControlSystemConfig(name, houseConfig, utilityConfig);

    //    ClimateControlSystemConfig systemConfigs = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(json.GetRawJsonValue());
    //    //ClimateControlSystemConfig systemConfigs = JsonUtility.FromJson<ClimateControlSystemConfig>(json);
    //    //ClimateControlSystemConfig systemConfigs = Newtonsoft.Json.JsonConvert.DeserializeObject<ClimateControlSystemConfig>(json);
    //    return systemConfigs;

    //}

    //public HouseConfig LoadHouseConfigFromJson(DataSnapshot json)
    //{
    //    HouseConfig houseConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<HouseConfig>(json.GetRawJsonValue());
    //    return houseConfig;
    //}

    //public UtilityConfig LoadUtilityFromJson(DataSnapshot json)
    //{
    //    UtilityConfig util = JsonUtility.FromJson<UtilityConfig>(json.GetRawJsonValue());
    //    return util;
    //}
}
