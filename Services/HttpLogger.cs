

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject.Services
{
    public static class HttpLogger
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task LogAsync(string message)
        {
            var content = new StringContent(
                $"{{\"message\": \"{message}\"}}",
                Encoding.UTF8,
                "application/json"
            );

            try
            {
                var response = await client.PostAsync("https://api-kodkod.onrender.com/log", content);
                response.EnsureSuccessStatusCode();
                Console.WriteLine("✅ Log sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Failed to send log: {ex.Message}");
            }
        }
    }
}