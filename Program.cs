using System;
using CommandoProject.Entities;

namespace CommandoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔧 Commando Operation Initialized!");

            var airCommando = new AirCommando("Eagle One", "Captain");
            var seaCommando = new SeaCommando("Shark Diver", "Lieutenant");

            airCommando.Attack();
            seaCommando.Attack();
        }
    }
}
