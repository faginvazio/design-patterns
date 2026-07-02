using UnityEngine;

public class SampleEffect : IAttackEffect
{
    public void Apply()
    {
        Debug.Log("Sample attack");
    }
}
