using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class UtilityRatesAndZip : MonoBehaviour
{
    public Dictionary<string, UtilityRates> stateRates = new();
    public Dictionary<int, string> zipToState = new();
    public bool isReady = false;

    void Awake()
    {
        string path = UnityEngine.Application.streamingAssetsPath + $"/UtiltyRatesFile/StateAndTerritoryRates.csv";
        char delimiter = ',';
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(delimiter);
                if (lineNumber != 0)
                {
                    string key = values[0].Trim();
                    float electricityPerKWH = float.Parse(values[1].Trim());
                    float gasPerTherm = float.Parse(values[2].Trim());
                    float oilPerGallon = float.Parse(values[3].Trim());
                    float woodPerPound = float.Parse(values[4].Trim());

                    UtilityRates utilityRates = new UtilityRates(electricityPerKWH, gasPerTherm, oilPerGallon, woodPerPound);

                    if (!stateRates.ContainsKey(key))
                    {
                        stateRates.Add(key, utilityRates);
                    }
                }
                lineNumber++;
            }
        }

        path = UnityEngine.Application.streamingAssetsPath + $"/UtiltyRatesFile/ZiptoState.csv";
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(delimiter);
                if (lineNumber != 0)
                {
                    int key = int.Parse(values[0].Trim());
                    string value = values[1].Trim();

                    if (!zipToState.ContainsKey(key))
                    {
                        zipToState.Add(key, value);
                    }
                }
                lineNumber++;
            }
            print($"zipToState Count: {zipToState.Count}");
        }



        isReady = true;
    }
}
