using UnityEngine;

public class AttackBuffDecorator : BuffDecorator
{
    private int bonusAttack;

    public AttackBuffDecorator(IBuff innerBuff, int bonusAttack, int duration) : base(innerBuff, duration)
    {
        this.bonusAttack = bonusAttack;
    }

    public override int GetAttackModifier()
    {
        return innerBuff.GetAttackModifier() + bonusAttack;
    }
}
