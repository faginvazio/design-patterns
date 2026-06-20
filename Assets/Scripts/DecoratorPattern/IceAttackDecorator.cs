using UnityEngine;

public class IceAttackDecorator : AttackDecorator
{
    public IceAttackDecorator(IAttack attack) : base(attack)
    {
    }

    public override void Execute()
    {
        base.Execute();

        Debug.Log("Ice Attack");
    }
}
