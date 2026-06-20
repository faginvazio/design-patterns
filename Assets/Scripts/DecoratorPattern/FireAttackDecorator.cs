using UnityEngine;

public class FireAttackDecorator : AttackDecorator
{
    public FireAttackDecorator(IAttack attack) : base(attack)
    {
    }

    public override void Execute()
    {
        base.Execute();

        Debug.Log("Fire Attack");
    }
   
}
