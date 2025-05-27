

public enum CommandoStatus
{
    Standing,
    Walking,
    Hiding
}

public class Commando
{
    private string name;
    public string CodeName { get; set; }
    public string[] Tools { get; private set; }
    public CommandoStatus Status { get; private set; }

    public Commando(string name, string codeName)
    {
        this.name = name;
        CodeName = codeName;
        Tools = new string[] { "Hammer", "Chisel", "Rope", "Bag", "Canteen" };
        Status = CommandoStatus.Standing;
    }

    public void Walk()
    {
        // TODO: Set status and print walking
    }

    public void Hide()
    {
        // TODO: Set status and print hiding
    }

    public virtual void Attack()
    {
        // TODO: Print attack message
    }
}