using System;
using System.Net.Http;
using System.Threading.Tasks;

class Test7
{
    static async Task Main(string[] args)
    {
        string result = await DownloadContentAsync();
        Console.WriteLine(result);
        string result1 = DownloadContent();
        Console.WriteLine(result1);
        string result2 = await DownloadContentAsync();
        Console.WriteLine(result2);
    }

    static async Task<string> DownloadContentAsync()
    {
        using HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("http://example.com");
        return result;
    }

    static string DownloadContent()
    {
        using HttpClient client = new HttpClient();
        string result = client.GetStringAsync("http://example.com");
        return result;
    }
}
