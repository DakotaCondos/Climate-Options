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
        GetGeographicCoordinates(zip);
    }

    public string BuildMonthlyURL(int month)
    {
        // https://history.openweathermap.org/data/2.5/aggregated/month?month=2&lat=35&lon=139&appid={API key}

        return $"https://history.openweathermap.org/data/2.5/aggregated/month?month={month}&lat=35&lon=139&appid={apiKey}";
    }




    public void GetGeographicCoordinates(int zip)
    {
        // http://api.openweathermap.org/geo/1.0/zip?zip=99004,US&appid=359cfddfedfd05916baa21b65c26f4f0
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

        // Once isProcessing is false, update the climateDataMonthList and listSize
        string jsonString = (string)helper.results.First();
        JObject jsonObject = JObject.Parse(jsonString);

        latitude = (double)jsonObject["lat"];
        longitude = (double)jsonObject["lon"];

        hasCoordinates = true;
        print($"Lat: {latitude}, Lon: {longitude}");
    }
}