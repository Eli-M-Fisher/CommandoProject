using System;
using CommandoProject.Utils;

public class Enemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        Logger.Log($"Enemy created: {Name} with {Health} health.");
        FileLogger.LogAsync($"Enemy created: {Name} with {Health} health.").Wait();
    }

    public void Shout()
    {
        Console.WriteLine("I am the enemy!!!");
        Logger.Log($"Enemy {Name} shouted.");
        FileLogger.LogAsync($"Enemy {Name} shouted.").Wait();
    }
}
