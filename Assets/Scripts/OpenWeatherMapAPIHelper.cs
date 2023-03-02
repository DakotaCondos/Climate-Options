using Newtonsoft.Json.Linq;
using System.Collections;
using System.Linq;
using UnityEngine;

public class OpenWeatherMapAPIHelper : MonoBehaviour
{
    JsonFetcher fetcher;
    [SerializeField] private string apiKey;
    public int zip;

    public double latitude;
    public double longitude;
    public bool hasCoordinates = false;
    public bool InitializeOnStart = false;


    public OpenWeatherMapAPIHelper(string apiKey, int zip)
    {
        this.apiKey = apiKey;
        this.zip = zip;
    }

    private void Awake()
    {
        fetcher = GetComponent<JsonFetcher>();
    }
    private void Start()
    {
        if (InitializeOnStart)
        {
            GetGeographicCoordinates(zip);
        }
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
        print($"Lat: {latitude}, Lon: {longitude}"); // debug line
    }
}