using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommandoProject.Services
{
    public static class IntelClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetIntelAsync()
        {
            try
            {
                var response = await client.GetAsync("https://api-kodkod.onrender.com/intel");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Failed to fetch intel: {ex.Message}");
                return "No intel available.";
            }
        }
    }
}