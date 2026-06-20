using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuffManager
{
    private IBuff buffChain = new NullBuff();

    public void AddBuff(IBuff newBuff)
    {
        newBuff = WrapWithExistingBuff(newBuff, buffChain);
        buffChain = newBuff;
    }

    private IBuff WrapWithExistingBuff(IBuff newBuff, IBuff existing)
    {
        if (newBuff is BuffDecorator decorator)
        {
            decorator.InnerBuff = existing;
            return decorator;
        }
        return newBuff;
    }

    public void UpdateBuffs()
    {
        buffChain = buffChain.Tick();

        while (buffChain is BuffDecorator decorator && decorator.Duration <= 0)
        {
            buffChain = decorator.InnerBuff;
        }
    }

    public int GetTotalAttackBonus()
    {
        return buffChain.GetAttackModifier();
    }

    public int GetTotalDefenseBonus()
    {
        return buffChain.GetDefenseModifier();
    }

    public void RemoveBuff<T>() where T : IBuff
    {
        buffChain = buffChain.RemoveDecorator<T>();
    }

    public IBuff GetBuffChain()
    {
        return buffChain;
    }

    public List<IBuff> GetAllBuffs()
    {
        return buffChain.GetBuffList();
    }
}
