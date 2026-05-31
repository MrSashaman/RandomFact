using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace RandomFact.MemeApi;

public class MemePage : PageModel
{
    private readonly HttpClient _httpClient;



    public MemePage(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

}
