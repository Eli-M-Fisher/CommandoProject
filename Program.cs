
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
    }
}
