//#if UNITY_EDITOR
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Linq;
using UnityEngine;

public class OpenWeatherMapAPIHelper : MonoBehaviour
{
    public JsonFetcher fetcher;
    [SerializeField] private string apiKey;
    public int zip;

    public double latitude;
    public double longitude;
    public bool hasCoordinates = false;

    private void Start()
    {
        fetcher = new();
    }

    public string BuildMonthlyURL(int month)
    {
        return $"https://history.openweathermap.org/data/2.5/aggregated/month?month={month}&lat={latitude}&lon={longitude}&appid={apiKey}";
    }

    public void GetGeographicCoordinates(int zip)
    {
        hasCoordinates = false;

        string url = $"http://api.openweathermap.org/geo/1.0/zip?zip={zip},US&appid={apiKey}";
        StartCoroutine(FetchGeographicCoordinates(url, zip));
    }

    private IEnumerator FetchGeographicCoordinates(string url, int zip)
    {
        AsyncRequestHelper helper = new();
        if (fetcher == null)
        {
            print("Fetcher Is Null");
        }
        fetcher.FetchJsonAsync(url, helper);

        // Wait for AsyncRequestHelper isProcessing to be false
        while (helper.isProcessing)
        {
            yield return null;
        }

        // Once isProcessing is true, pull result from helper and parse data
        string jsonString = (string)helper.results.First();
        JObject jsonObject = JObject.Parse(jsonString);

        latitude = (double)jsonObject["lat"];
        longitude = (double)jsonObject["lon"];

        hasCoordinates = true;
    }
}
// current file contents
//#endif