using UnityEngine;

public abstract class Weapon
{
    protected IAttackEffect attackEffect;

    public Weapon(IAttackEffect attackEffect)
    {
        this.attackEffect = attackEffect;
    }

    public abstract void Attack();
}
