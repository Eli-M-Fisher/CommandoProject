

using CommandoProject.Utils;

using System;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName)
        : base(name, codeName)
    {
    }

    public void Swim()
    {
        Console.WriteLine($"{CodeName} is swimming through enemy waters!");
    }

    public override void Attack()
    {
        Console.WriteLine($"Sea Commando {CodeName} is attacking from the sea!");
        Logger.Log($"Sea Commando {CodeName} attacked from the sea.");
    }
}