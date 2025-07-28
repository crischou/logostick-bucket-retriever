using Xunit;
using System.Net.Http;
using System.Threading.Tasks;

public class InterfaceIntegrationTest
{

    private readonly HttpClient _client;

    public InterfaceIntegrationTest()
    {
        _client = new HttpClient();
        _client.BaseAddress = new System.Uri("http://localhost:8000");
    }
    [Fact]
    public async Task SendingMessageTest()
    {
        var response = await _client.GetAsync("/bucket-retriever/messages/");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        Assert.Contains("API Call Received", content);
    }

}