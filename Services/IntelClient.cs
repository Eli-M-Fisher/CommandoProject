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
                Console.WriteLine("🔍 Starting to fetch intel...");
                var response = await client.GetAsync("https://api-kodkod.onrender.com/intel");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("✅ Successfully fetched intel.");
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Failed to fetch intel: {ex.Message}");
                return "No intel available.";
            }
        }

        public static async Task PrintIntelAsync()
        {
            Console.WriteLine("\n=== Intel Report ===");

            var intel = await GetIntelAsync();
            Console.WriteLine($"📡 Intel Data: {intel}");

            Console.WriteLine("=== End of Report ===\n");
        }
    }
}