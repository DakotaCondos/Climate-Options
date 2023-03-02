using System.IO;
using System.Net;
using System.Text;

public class JsonFetcher
{
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
