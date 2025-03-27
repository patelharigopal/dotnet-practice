using System;
using System.Net.Http;
using System.Threading.Tasks;

class Test7
{
    async Task Method1()
    {
        string result1 = await DownloadContentAsync();
        Console.WriteLine(result1);
		
        string result2 = DownloadContent();
        Console.WriteLine(result2);
		
        string result3 = await DownloadContentAsync();
        Console.WriteLine(result3);
    }
	
	async Task Method2()
    {
        string result1 = await DownloadContentAsync();
        Console.WriteLine(result1);
		
        string result2 = await DownloadContentAsync();
        Console.WriteLine(result2);
		
        string result3 = await DownloadContentAsync();
        Console.WriteLine(result3);
    }
	
	async Task Method3()
    {
        string result1 = DownloadContent();
        Console.WriteLine(result1);
		
        string result2 = await DownloadContentAsync();
        Console.WriteLine(result2);
		
        string result3 = await DownloadContentAsync();
        Console.WriteLine(result3);
    }

    async Task<string> DownloadContentAsync()
    {
        using HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("http://example.com");
        return result;
    }

    string DownloadContent()
    {
        using HttpClient client = new HttpClient();
        string result = client.GetString("http://example.com");
        return result;
    }
}
