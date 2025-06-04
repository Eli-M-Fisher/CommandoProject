namespace CommandoProject.Interfaces
{
    public interface IShootable
    {
        int BulletCount { get; }
        void Shoot();
    }
}
