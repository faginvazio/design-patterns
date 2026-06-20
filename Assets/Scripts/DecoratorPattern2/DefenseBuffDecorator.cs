using UnityEngine;

public class DefenseBuffDecorator : BuffDecorator
{
    private int bonusDefense;

    public DefenseBuffDecorator(IBuff innerBuff, int bonusDefense, int duration) : base(innerBuff, duration)
    {
        this.bonusDefense = bonusDefense;
    }

    public override int GetDefenseModifier()
    {
        return innerBuff.GetDefenseModifier() + bonusDefense;
    }
}
