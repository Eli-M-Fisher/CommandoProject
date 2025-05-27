using System;

public class Enemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
    }

    public void Shout()
    {
        Console.WriteLine("I am the enemy!!!");
    }
}
