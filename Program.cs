using System.Threading.Tasks;
using System;
using System.Collections.Generic;

class Program
{
    static async Task Main(string[] args)
    {
        Game game = new Game();
        await game.Start();
    }
}
