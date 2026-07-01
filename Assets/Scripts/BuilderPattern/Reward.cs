using System.Collections.Generic;


public class Reward
{
    public int Gold;
    public int Exp;
    public List<string> Items = new();

    public override string ToString()
    {
        return $"Gold: {Gold}, Exp: {Exp}, Item: {string.Join(", ", Items)}";
    }
}
