using UnityEngine;

public class AttackDecorator : IAttack
{
    protected IAttack baseAttack;

    public AttackDecorator(IAttack attack)
    {
        baseAttack = attack;
    }

    public virtual void Execute()
    {
        baseAttack.Execute();
    }
}
