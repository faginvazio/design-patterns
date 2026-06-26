using UnityEngine;

public class EnemyKilledEvent : GameEvent
{
    public int enemyId;
    public EnemyKilledEvent(int enemyId)
    {
        this.enemyId = enemyId;
    }
}
