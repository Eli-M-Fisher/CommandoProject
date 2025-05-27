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
            Console.WriteLine($"Calling Attack() on: {c.GetType().Name}");
            c.Attack();
        }
        // Enemy and EnemyFactory test
        EnemyFactory enemyFactory = new EnemyFactory();
        Enemy enemy1 = enemyFactory.CreateEnemy("Enemy One");
        Enemy enemy2 = enemyFactory.CreateEnemy("Enemy Two");

        enemy1.Shout();
        enemy2.Shout();

        Console.WriteLine($"Total enemies created: {enemyFactory.GetAllEnemies().Count}");

        // CommandoFactory test
        CommandoFactory commandoFactory = new CommandoFactory();
        Commando regular = commandoFactory.CreateCommando("Alex Stone", "Shadow", "regular");
        Commando air = commandoFactory.CreateCommando("Liam Sky", "Falcon", "air");
        Commando sea = commandoFactory.CreateCommando("Noah Wave", "Shark", "sea");

        Console.WriteLine($"Total commandos created: {commandoFactory.GetAllCommandos().Count}");
        foreach (Commando cmd in commandoFactory.GetAllCommandos())
        {
            Console.WriteLine($"Commando created: {cmd.CodeName} ({cmd.GetType().Name})");
        }

        // WeaponFactory test
        WeaponFactory weaponFactory = new WeaponFactory();
        Weapon m16 = weaponFactory.CreateWeapon("M16");
        Weapon ak47 = weaponFactory.CreateWeapon("AK47");

        m16.Shoot();
        ak47.Shoot();

        Console.WriteLine($"Total weapons created: {weaponFactory.GetAllWeapons().Count}");
        foreach (Weapon wp in weaponFactory.GetAllWeapons())
        {
            Console.WriteLine($"Weapon created: {wp.Name} ({wp.Manufacturer}) with {wp.BulletCount} bullets");
        }
    }
}
