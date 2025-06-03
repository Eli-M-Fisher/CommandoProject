

using System;
using System.IO;

namespace CommandoProject.Input
{
    public static class ScenarioLoader
    {
        public static string[] LoadScenario(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Scenario file not found: {filePath}");
                return Array.Empty<string>();
            }

            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading scenario file: {ex.Message}");
                return Array.Empty<string>();
            }
        }
    }
}