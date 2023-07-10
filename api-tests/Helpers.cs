using System.Net.Http.Json;

namespace Tests;

public class ApiHelper
{
    static public async Task<T> Get<T>(string url, HttpClient httpClient)
    {
        var response = await httpClient.GetFromJsonAsync<T>($"{url}");

        if (response == null)
        {
            throw new Exception();
        }

        return response;
    }
}
