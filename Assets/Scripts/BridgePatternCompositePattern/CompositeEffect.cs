using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CompositeEffect : IAttackEffect
{
    private List<IAttackEffect> attackEffects = new();


    public void AddAttackEffect(IAttackEffect attackEffect)
    {
        if (!attackEffects.Contains(attackEffect))
        {
            attackEffects.Add(attackEffect);
            Debug.Log($"[Effect] {attackEffect.GetType().Name} added");
        }
    }

    public void RemoveAttackEffect(IAttackEffect attackEffect)
    {
        if (attackEffects.Remove(attackEffect))
        {
            Debug.Log($"[Effect] {attackEffect.GetType().Name} removed");
        }
    }

    public void ClearAttackEffects()
    {
        attackEffects.Clear();
        Debug.Log("[Effect] all effect removed");
    }

    public IEnumerable<IAttackEffect> GetAllEffects() => attackEffects;



    public void Apply()
    {
        foreach (var attackEffect in attackEffects)
        { 
            attackEffect.Apply();
        }
    }
}
