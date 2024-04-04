public async Task<string[]> GetRepos()
{
    // Assuming 'httpClient' is an instance of HttpClient already set up for example API requests
    httpClient.DefaultRequestHeaders.Add("User-Agent", "request");

    // Replace 'username' with the actual example username
    string url = "https://www.example.com    try
    {
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        
        // Parse the JSON response and return the repository names
        var repos = JArray.Parse(responseBody)
            .Select(repo => repo["name"].ToString())
            .ToArray();
        
        return repos;
    }
    catch(HttpRequestException e)
    {
        Console.WriteLine("\nException Caught!");
        Console.WriteLine("Message :{0} ", e.Message);
        return new string[0];
    }
}
