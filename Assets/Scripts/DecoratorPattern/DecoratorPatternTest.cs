using UnityEngine;

public class DecoratorPatternTest : MonoBehaviour
{

    private void Start()
    {
        IAttack attack = new BasicAttack();

        attack = new FireAttackDecorator(attack);
        attack = new IceAttackDecorator(attack);

        attack.Execute();
    }
}
