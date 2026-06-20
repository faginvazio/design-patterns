using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuffSystemTest : MonoBehaviour
{
    public int baseAttack = 50;
    public int baseDefense = 30;

    private BuffManager buffManager = new BuffManager();

    private void Start()
    {
        Debug.Log($"base attack: {baseAttack}, base defense: {baseDefense}");

        buffManager.AddBuff(new AttackBuffDecorator(buffManager.GetBuffChain(), 20, 3));

        buffManager.AddBuff(new DefenseBuffDecorator(buffManager.GetBuffChain(), 10, 2));

        PrintCurrentStats();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("turn");
            buffManager.UpdateBuffs();
            PrintCurrentStats();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("remove attack buff");
            buffManager.RemoveBuff<AttackBuffDecorator>();
            PrintCurrentStats();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            List<IBuff> buffs = buffManager.GetAllBuffs();
            Debug.Log($"buff count: {buffs.Count}");
            foreach(var buff in buffs)
            {
                if (buff is BuffDecorator decorator)
                {
                    Debug.Log($"buff type: {decorator.GetType().Name}, turn: {decorator.Duration}");
                }
            }
        }
    }

    private void PrintCurrentStats()
    {
        int totalAttack = baseAttack + buffManager.GetTotalAttackBonus();
        int totalDefense = baseDefense + buffManager.GetTotalDefenseBonus();

        Debug.Log($"total attack: {totalAttack}, total defense: {totalDefense}");
    }
}
