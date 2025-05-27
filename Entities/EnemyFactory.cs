

using System;
using System.Collections.Generic;

public class EnemyFactory
{
    private List<Enemy> enemies = new List<Enemy>();

    public Enemy CreateEnemy(string name)
    {
        Enemy newEnemy = new Enemy(name);
        enemies.Add(newEnemy);
        return newEnemy;
    }

    public List<Enemy> GetAllEnemies()
    {
        return enemies;
    }
}