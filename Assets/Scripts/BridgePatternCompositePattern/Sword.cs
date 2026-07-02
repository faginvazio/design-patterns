using UnityEngine;

public class Sword : Weapon
{

    public Sword(IAttackEffect attackEffect) : base(attackEffect) { }
  
    public override void Attack()
    {
        Debug.Log("Sword attack");
        attackEffect.Apply();
    }
}
