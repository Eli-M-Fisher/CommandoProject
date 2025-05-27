

using System;

public class Game
{
    private CommandoFactory commandoFactory;
    private WeaponFactory weaponFactory;
    private BreakableFactory breakableFactory;
    private EnemyFactory enemyFactory;

    public Game()
    {
        commandoFactory = new CommandoFactory();
        weaponFactory = new WeaponFactory();
        breakableFactory = new BreakableFactory();
        enemyFactory = new EnemyFactory();
    }

    public void Start()
    {
        Console.WriteLine("Game started...\n");

        RunCommandoDemo();
        RunWeaponDemo();
        RunBreakableDemo();
        RunEnemyDemo();
    }

    private void RunCommandoDemo()
    {
        Console.WriteLine("=== Commando Demo ===");
        Commando regular = commandoFactory.CreateCommando("Alex Stone", "Shadow", "regular");
        Commando air = commandoFactory.CreateCommando("Liam Sky", "Falcon", "air");
        Commando sea = commandoFactory.CreateCommando("Noah Wave", "Shark", "sea");

        foreach (Commando cmd in commandoFactory.GetAllCommandos())
        {
            Console.WriteLine($"Commando created: {cmd.CodeName} ({cmd.GetType().Name})");
            cmd.Attack();
        }

        Console.WriteLine();
    }

    private void RunWeaponDemo()
    {
        Console.WriteLine("=== Weapon Demo ===");
        Weapon m16 = weaponFactory.CreateWeapon("M16");
        Weapon ak47 = weaponFactory.CreateWeapon("AK47");

        m16.Shoot();
        ak47.Shoot();

        foreach (Weapon wp in weaponFactory.GetAllWeapons())
        {
            Console.WriteLine($"Weapon: {wp.Name}, Bullets: {wp.BulletCount}");
        }

        Console.WriteLine();
    }

    private void RunBreakableDemo()
    {
        Console.WriteLine("=== Breakable Demo ===");
        IBreakable stone = breakableFactory.CreateBreakable("stone");
        IBreakable knife = breakableFactory.CreateBreakable("knife");

        for (int i = 0; i < 6; i++) stone.Hit();
        for (int i = 0; i < 11; i++) knife.Hit();

        Console.WriteLine();
    }

    private void RunEnemyDemo()
    {
        Console.WriteLine("=== Enemy Demo ===");
        Enemy enemy1 = enemyFactory.CreateEnemy("Enemy One");
        Enemy enemy2 = enemyFactory.CreateEnemy("Enemy Two");

        enemy1.Shout();
        enemy2.Shout();

        Console.WriteLine($"Total enemies created: {enemyFactory.GetAllEnemies().Count}\n");
    }
}