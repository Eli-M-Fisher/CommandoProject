using System;
using System.Threading.Tasks;
using CommandoProject.Services;
using CommandoProject.Utils;

public class Game
{
    private string[] scenarioLines;

    private CommandoFactory commandoFactory;
    private WeaponFactory weaponFactory;
    private BreakableFactory breakableFactory;
    private EnemyFactory enemyFactory;

    public Game(string[] scenarioLines)
    {
        this.scenarioLines = scenarioLines;
        commandoFactory = new CommandoFactory();
        weaponFactory = new WeaponFactory();
        breakableFactory = new BreakableFactory();
        enemyFactory = new EnemyFactory();
    }

    public async Task Start()
    {
        Console.WriteLine("=== GAME SIMULATION START ===\n");

        RunEnemyDemo();
        RunCommandoDemo();
        RunWeaponDemo();
        RunBreakableDemo();

        Console.WriteLine("=== GAME SIMULATION END ===\n");

        await HttpLogger.LogAsync("📡 Simulation ended — log transmitted.");
    }

    private void RunCommandoDemo()
    {
        Console.WriteLine("=== Commando Demo ===");

        Commando regular = commandoFactory.CreateCommando("Alex Stone", "Shadow", "regular");
        Commando air = commandoFactory.CreateCommando("Liam Sky", "Falcon", "air");
        Commando sea = commandoFactory.CreateCommando("Noah Wave", "Shark", "sea");

        var allCommandos = commandoFactory.GetAllCommandos();

        for (int i = 0; i < allCommandos.Count; i++)
        {
            var cmd = allCommandos[i];
            Console.WriteLine($"\n>> Commando #{i + 1}: {cmd.CodeName}");
            Console.WriteLine($"Type: {cmd.GetType().Name}");
            Console.WriteLine("Action:");
            cmd.Attack();
        }

        Console.WriteLine($"\nTotal commandos created: {allCommandos.Count}\n");
    }

    private void RunWeaponDemo()
    {
        Console.WriteLine("=== Weapon Demo ===");

        Weapon m16 = weaponFactory.CreateWeapon("M16");
        Weapon ak47 = weaponFactory.CreateWeapon("AK47");

        List<Weapon> allWeapons = weaponFactory.GetAllWeapons();

        for (int i = 0; i < allWeapons.Count; i++)
        {
            var weapon = allWeapons[i];
            Console.WriteLine($"\n>> Weapon #{i + 1}: {weapon.Name} ({weapon.Manufacturer})");
            Console.WriteLine("Action: Shooting...");
            weapon.Shoot();
            Console.WriteLine($"Remaining bullets: {weapon.BulletCount}");
        }

        Console.WriteLine($"\nTotal weapons created: {allWeapons.Count}\n");
    }

    private void RunBreakableDemo()
    {
        Console.WriteLine("=== Breakable Demo ===");

        IBreakable stone = breakableFactory.CreateBreakable("stone");
        IBreakable knife = breakableFactory.CreateBreakable("knife");

        Console.WriteLine("\n-- Testing Stone: Heavy Stone --");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"[{i}/5] ");
            stone.Hit();
        }

        Console.WriteLine("\n-- Testing Knife: Combat Knife --");
        for (int i = 1; i <= 11; i++)
        {
            Console.Write($"[{i}/10] ");
            knife.Hit();
        }

        Console.WriteLine();
    }

    private void RunEnemyDemo()
    {
        Console.WriteLine("=== Enemy Demo ===");

        List<Enemy> enemies = new List<Enemy>
        {
            enemyFactory.CreateEnemy("Enemy One"),
            enemyFactory.CreateEnemy("Enemy Two")
        };

        for (int i = 0; i < enemies.Count; i++)
        {
            Enemy enemy = enemies[i];
            Console.WriteLine($"\n>> Enemy #{i + 1}: {enemy.Name} | Status: {(enemy.IsAlive ? "Alive" : "Dead")}");
            Console.WriteLine("Shouting:");
            enemy.Shout();
        }

        Console.WriteLine($"\nTotal enemies created: {enemyFactory.GetAllEnemies().Count}\n");
    }
}