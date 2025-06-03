using System;
using CommandoProject.Utils;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName)
        : base(name, codeName)
    {
    }

    public void Parachute()
    {
        Console.WriteLine($"{CodeName} is parachuting from the sky!");
    }

    public override void Attack()
    {
        Console.WriteLine($"Air Commando {CodeName} is attacking from the air!");
        Logger.Log($"Air Commando {CodeName} attacked from the air.");
    }
}
