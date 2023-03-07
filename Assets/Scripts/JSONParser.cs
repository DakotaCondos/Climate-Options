using UnityEngine;
using System.Collections.Generic;

public class JSONParser
{
    public static List<string> ParseJSON(string jsonString)
    {
        // List to store individual JSON objects
        List<string> jsonStrings = new List<string>();

        // Split the input string by '}{' to separate JSON objects
        string[] jsonObjects = jsonString.Split(new string[] { "},{" }, System.StringSplitOptions.None);

        // Add the start and end braces to each JSON string
        for (int i = 0; i < jsonObjects.Length; i++)
        {
            if (i == 0)
            {
                jsonObjects[i] = jsonObjects[i] + "}";
            }
            else if (i == jsonObjects.Length - 1)
            {
                jsonObjects[i] = "{" + jsonObjects[i];
            }
            else
            {
                jsonObjects[i] = "{" + jsonObjects[i] + "}";
            }
        }

        // Add each JSON string to the list of JSON strings
        foreach (string s in jsonObjects)
        {
            jsonStrings.Add(s);
        }

        // Return the list of JSON strings
        return jsonStrings;
    }
}
