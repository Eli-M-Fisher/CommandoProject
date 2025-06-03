

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject.Utils
{
    public static class FileLogger
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string endpointUrl = "https://api-kodkod.onrender.com/log"; // לדוגמה

        public static async Task LogAsync(string message)
        {
            try
            {
                var json = $"{{\"message\": \"{message}\"}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(endpointUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"[HTTP LOGGING FAILED] Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HTTP LOGGER EXCEPTION] {ex.Message}");
            }
        }
    }
}