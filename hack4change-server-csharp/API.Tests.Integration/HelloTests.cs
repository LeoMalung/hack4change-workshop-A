using Microsoft.AspNetCore.Mvc.Testing;

namespace Hack4Change.API.Tests.Integration;

/// <summary>
/// This is a simple test class to demonstrate how integration tests can be written for this server.
/// </summary>
public class HelloTests
{
    private const string WELCOME = "Welcome to the Hack4Change Web Server";
    private const string PATH = "/hello";

    [Fact]
    public async Task GET_ReturnsSuccessCode()
    {
        await using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        var response = await client.GetAsync(PATH);

        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task GET_ReturnsWelcomeMessage()
    {
        await using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        var response = await client.GetAsync(PATH);

        var text = await response.Content.ReadAsStringAsync();

        Assert.Equal(WELCOME, text);
    }
}
