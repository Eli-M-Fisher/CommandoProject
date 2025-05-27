public interface IBreakable
{
    string Status { get; }
    int MaxHits { get; }
    int CurrentHits { get; }

    void Hit();
}
