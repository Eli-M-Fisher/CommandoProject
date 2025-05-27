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
        // TODO: Decrease bullet count and print shooting message
    }
}
