using CommandoProject.Utils;
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
        Status = CommandoStatus.Walking;
        Console.WriteLine($"{CodeName} is walking.");
    }

    public void Hide()
    {
        Status = CommandoStatus.Hiding;
        Console.WriteLine($"{CodeName} is hiding.");
    }

    public virtual void Attack()
    {
        Console.WriteLine($"Commando {CodeName} is attacking!");
        Logger.Log($"Commando {CodeName} is attacking.");
    }

    public string SayName(string commanderRank)
    {
        if (commanderRank == "GENERAL")
        {
            return name;
        }
        else if (commanderRank == "COLONEL")
        {
            return CodeName;
        }
        else
        {
            return "Access denied. Classified information.";
        }
    }
}