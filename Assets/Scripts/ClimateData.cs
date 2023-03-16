//#if UNITY_EDITOR
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Linq;
using UnityEngine;

public class ClimateData : MonoBehaviour
{
    JsonFetcher fetcher;
    public ClimateDataMonth[] climateDataMonths = new ClimateDataMonth[12];
    public int monthsCompleted = 0;
    public OpenWeatherMapAPIHelper openWeatherMapAPIHelper;
    public bool isDataReady = false;
    public bool initializeOnStart = false;
    public int zip;

    private void Awake()
    {
        openWeatherMapAPIHelper = GetComponent<OpenWeatherMapAPIHelper>();
        fetcher = new();
    }

    private void Start()
    {
        if (!initializeOnStart) return;
        if (zip != 0)
        {
            GetYearClimateData(zip);
        }
        else
        {
            print("Initialize on start failed. Zip Code required in editor");
        }
    }

    public void GetYearClimateData(int zip)
    {
        isDataReady = false;
        monthsCompleted = 0;
        for (int i = 0; i < climateDataMonths.Length; i++)
        {
            climateDataMonths[i] = null;
        }

        StartCoroutine(FetchYearClimateData(zip));
    }

    private IEnumerator FetchYearClimateData(int zip)
    {
        openWeatherMapAPIHelper.GetGeographicCoordinates(zip);
        // Wait for OpenWeatherMapAPIHelper to have coordinates
        while (!openWeatherMapAPIHelper.hasCoordinates)
        {
            yield return null;
        }

        // start requests for each months data
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

        // Once isProcessing is true, pull result from helper and parse data
        string jsonString = (string)helper.results.First();
        JObject jsonObject = JObject.Parse(jsonString);

        int month = (int)jsonObject["result"]["month"];
        double averageTemperature = (double)jsonObject["result"]["temp"]["mean"];
        ClimateDataMonth climateDataMonth = new(month, averageTemperature);
        climateDataMonths[index] = climateDataMonth;
        monthsCompleted++;
    }
}
// current file contents
//#endif