

using System;
using System.Collections.Generic;

public class CommandoFactory
{
    private List<Commando> commandos = new List<Commando>();

    public Commando CreateCommando(string name, string codeName, string type)
    {
        Commando newCommando;
        switch (type.ToLower())
        {
            case "air":
                newCommando = new AirCommando(name, codeName);
                break;
            case "sea":
                newCommando = new SeaCommando(name, codeName);
                break;
            default:
                newCommando = new Commando(name, codeName);
                break;
        }

        commandos.Add(newCommando);
        return newCommando;
    }

    public List<Commando> GetAllCommandos()
    {
        return commandos;
    }
}