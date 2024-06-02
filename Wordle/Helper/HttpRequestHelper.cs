using System.Net;
using System.Text.Json;

namespace Wordle.Helper
{
    internal class HttpRequestHelper<T>
    {
        public async Task<T> GetTodaysWord(string url, string query)
        {
            T result = default;
            // Set appropriate security protocols
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // Create the request
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send the GET request and wait for the response
                    HttpResponseMessage response = await client.GetAsync(url + query);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content of the response as a stream and deserialize it into a C# object
                        using (var responseStream = await response.Content.ReadAsStreamAsync())
                        {
                            result = await JsonSerializer.DeserializeAsync<T>(responseStream);
                        }
                    }
                    else
                    {
                        // If the request was not successful, output the status code
                        throw new Exception("Request failed with status code: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException e)
                {
                    // If an exception occurs during the request, output the error message
                    throw e;
                }
            }
            return result;
        }
    }
}
