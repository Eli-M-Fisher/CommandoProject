

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
        Console.WriteLine("Game started...");
        // TODO: Call setup and demo methods here
    }
}