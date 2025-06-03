using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using CommandoProject.Services;

class Program
{
    static async Task Main(string[] args)
    {
        string[] scenarioLines = CommandoProject.Input.ScenarioLoader.LoadScenario("scenario.txt");
        Game game = new Game(scenarioLines);
        await game.Start();
        await CommandoProject.Services.IntelClient.PrintIntelAsync();
    }
}
