using UnityEngine;

public class GameManagerBPCP : MonoBehaviour
{
    private IAttackEffect attackEffect = new SampleEffect();
    private IAttackEffect newEffect = new NewEffect();
    private IAttackEffect oldEffect = new OldEffect();
    private CompositeEffect compositeEffect;

    private Sword sword;

    private void Start()
    {
        sword = new Sword(attackEffect);

        compositeEffect = new CompositeEffect();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //sword.Attack();
            foreach (var effect in compositeEffect.GetAllEffects())
            {
                sword = new Sword(effect);
                sword.Attack();
            }
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            compositeEffect.AddAttackEffect(newEffect);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            compositeEffect.AddAttackEffect(oldEffect);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            compositeEffect.AddAttackEffect(newEffect);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            compositeEffect.AddAttackEffect(attackEffect);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            compositeEffect.RemoveAttackEffect(oldEffect);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            compositeEffect.ClearAttackEffects();
        }
    }
}