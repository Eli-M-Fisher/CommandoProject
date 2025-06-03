using CommandoProject.Utils;
public class Weapon
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int BulletCount { get; private set; }

    public Weapon(string name, string manufacturer, int bulletCount)
    {
        Name = name;
        Manufacturer = manufacturer;
        BulletCount = bulletCount;
    }

    public void Shoot()
    {
        if (BulletCount > 0)
        {
            BulletCount--;
            Console.WriteLine($"{Name} fired a shot! Bullets left: {BulletCount}");
            Logger.Log($"{Name} fired a shot! Bullets left: {BulletCount}");
        }
        else
        {
            Console.WriteLine($"{Name} is out of bullets!");
            Logger.Log($"{Name} is out of bullets!");
        }
    }
}
