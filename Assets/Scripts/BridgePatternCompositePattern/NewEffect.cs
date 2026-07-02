using UnityEngine;

public class NewEffect : IAttackEffect
{
    public void Apply()
    {
        Debug.Log("new attack");
    }
}
