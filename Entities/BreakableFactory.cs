using System;
using System.Collections.Generic;

public interface IBreakableCreator
{
    IBreakable Create();
}

public class StoneCreator : IBreakableCreator
{
    public IBreakable Create()
    {
        return new Stone("Heavy Stone", 2.5, "Gray");
    }
}

public class KnifeCreator : IBreakableCreator
{
    public IBreakable Create()
    {
        return new Knife("Combat Knife", "Steel", "SharpEdge", "Black", 0.8);
    }
}

public class BreakableFactory
{
    private Dictionary<string, IBreakableCreator> creators = new();

    public BreakableFactory()
    {
        creators["stone"] = new StoneCreator();
        creators["knife"] = new KnifeCreator();
    }

    public IBreakable CreateBreakable(string type)
    {
        if (!creators.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException($"Unknown breakable type: {type}");
        }

        return creators[type.ToLower()].Create();
    }
}
