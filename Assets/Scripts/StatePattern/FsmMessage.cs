using UnityEngine;

public struct FsmMessage
{
    public int Type;
    public FsmMessage(int type)
    {
        Type = type;
    }
}
