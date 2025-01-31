using System;
using System.Net.Http;
using System.Threading.Tasks;

class Test6
{
    static async Task Main(string[] args)
    {
        string result = await DownloadContentAsync();
        Console.WriteLine(result);
        string result1 = DownloadContentAsync();
        Console.WriteLine(result1);
    }

    static async Task<string> DownloadContentAsync()
    {
        using HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("http://example.com");
        return result;
    }
}
