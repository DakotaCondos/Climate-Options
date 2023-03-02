using UnityEngine;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System;


public class JsonFetcher : MonoBehaviour
{
    //public async Task<ClimateDataMonth> FetchClimateDataMonthAsync(string url)
    //{
    //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    //    request.Method = "GET";
    //    request.ContentType = "application/json";
    //    request.Timeout = 30000;

    //    using var response = await request.GetResponseAsync() as HttpWebResponse;
    //    using var stream = response.GetResponseStream();
    //    using var reader = new StreamReader(stream, Encoding.UTF8);
    //    string jsonString = await reader.ReadToEndAsync();
    //    JObject jsonObject = JObject.Parse(jsonString);

    //    int month = (int)jsonObject["result"]["month"];
    //    double averageTemperature = (double)jsonObject["result"]["temp"]["mean"];
    //    ClimateDataMonth climateDataMonth = new(month, averageTemperature);
    //    return climateDataMonth;
    //}

    //public async void StartFetchJsonAsync(string url, ClimateData climateData)
    //{
    //    ClimateDataMonth climateDataMonth = await FetchClimateDataMonthAsync(url);
    //    climateData.isProcessing = false;
    //    climateData.climateDataMonths.Add(climateDataMonth);
    //}


    public async void FetchJsonAsync(string url, AsyncRequestHelper helper)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Timeout = 30000;

        using var response = await request.GetResponseAsync() as HttpWebResponse;
        using var stream = response.GetResponseStream();
        using var reader = new StreamReader(stream, Encoding.UTF8);
        string jsonString = await reader.ReadToEndAsync();

        helper.results.Add(jsonString);
        helper.isProcessing = false;
    }
}
