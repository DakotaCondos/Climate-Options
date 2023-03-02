using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ClimateData : MonoBehaviour
{
    JsonFetcher fetcher;
    public ClimateDataMonth[] climateDataMonths = new ClimateDataMonth[12];
    public int monthsCompleted = 0;
    public OpenWeatherMapAPIHelper openWeatherMapAPIHelper;
    public bool isDataReady = false;
    public bool initializeOnStart = true;

    private void Awake()
    {
        fetcher = GetComponent<JsonFetcher>();
        openWeatherMapAPIHelper = GetComponent<OpenWeatherMapAPIHelper>();
    }
    private void Start()
    {
        if (initializeOnStart) { GetYearClimateData(); }
    }

    public void GetYearClimateData()
    {
        StartCoroutine(FetchYearClimateData());
    }

    public void Testing(string url)
    {
        GetMonthsClimateData(url, 0);
    }
    public void GetMonthsClimateData(string url, int index)
    {
        StartCoroutine(FetchMonthClimateData(url, index));
    }

    private IEnumerator FetchMonthClimateData(string url, int index)
    {
        AsyncRequestHelper helper = new();
        fetcher.FetchJsonAsync(url, helper);

        // Wait for isProcessing to be false
        while (helper.isProcessing)
        {
            yield return null;
        }

        // Once isProcessing is false, update the climateDataMonthList and listSize
        string jsonString = (string)helper.results.First();
        JObject jsonObject = JObject.Parse(jsonString);

        int month = (int)jsonObject["result"]["month"];
        double averageTemperature = (double)jsonObject["result"]["temp"]["mean"];
        ClimateDataMonth climateDataMonth = new(month, averageTemperature);
        climateDataMonths[index] = climateDataMonth;

        //debugging
        monthsCompleted++;
        print(climateDataMonths[index]);
    }

    private IEnumerator FetchYearClimateData()
    {
        // Wait for OpenWeatherMapAPIHelper to have coordinates
        while (!openWeatherMapAPIHelper.hasCoordinates)
        {
            yield return null;
        }

        for (int i = 0; i < climateDataMonths.Length; i++)
        {
            GetMonthsClimateData(openWeatherMapAPIHelper.BuildMonthlyURL(i + 1), i);
        }

        //Wait for all months data to be added
        while (monthsCompleted < 12)
        {
            yield return null;
        }
        isDataReady = true;
    }
}
