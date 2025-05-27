using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Commando commando = new Commando("John Smith", "Ghost");
        Console.WriteLine($"Commando Code Name: {commando.CodeName}");
        Console.WriteLine($"Commando Tools: {string.Join(", ", commando.Tools)}");
        Console.WriteLine($"Commando Status: {commando.Status}");

        Weapon weapon = new Weapon("Rifle", "MilTech", 30);
        Console.WriteLine($"Weapon: {weapon.Name} by {weapon.Manufacturer} with {weapon.BulletCount} bullets");

        Console.WriteLine("SayName for GENERAL: " + commando.SayName("GENERAL"));
        Console.WriteLine("SayName for COLONEL: " + commando.SayName("COLONEL"));
        Console.WriteLine("SayName for CAPTAIN: " + commando.SayName("CAPTAIN"));

        AirCommando airCommando = new AirCommando("James Blaze", "Falcon");
        SeaCommando seaCommando = new SeaCommando("Mark Tide", "Shark");

        airCommando.Parachute();
        seaCommando.Swim();

        Commando[] commandos = new Commando[] { commando, airCommando, seaCommando };
        foreach (Commando c in commandos)
        {
            c.Attack();
        }
    }
}
