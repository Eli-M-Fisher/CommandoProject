using System;
using System.Collections.Generic;

namespace CommandoProject.Entities
{
public interface ICommandoCreator
{
    Commando Create(string name, string codeName);
}

public class RegularCommandoCreator : ICommandoCreator
{
    public Commando Create(string name, string codeName) =>
        new Commando(name, codeName);
}

public class AirCommandoCreator : ICommandoCreator
{
    public Commando Create(string name, string codeName) =>
        new AirCommando(name, codeName);
}

public class SeaCommandoCreator : ICommandoCreator
{
    public Commando Create(string name, string codeName) =>
        new SeaCommando(name, codeName);
}

public class CommandoFactory
{
    private List<Commando> commandos = new List<Commando>();
    private Dictionary<string, ICommandoCreator> creators = new Dictionary<string, ICommandoCreator>();

    public CommandoFactory()
    {
        creators["regular"] = new RegularCommandoCreator();
        creators["air"] = new AirCommandoCreator();
        creators["sea"] = new SeaCommandoCreator();
    }

    public Commando CreateCommando(string name, string codeName, string type)
    {
        if (!creators.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException($"Unknown commando type: {type}");
        }

        Commando newCommando = creators[type.ToLower()].Create(name, codeName);
        commandos.Add(newCommando);
        return newCommando;
    }

    public List<Commando> GetAllCommandos()
    {
        return commandos;
    }
}
}