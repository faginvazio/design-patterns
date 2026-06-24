using UnityEngine;

public class ChaseState : FsmState<EnemyState>
{
    private EnemySP enemy;

    public ChaseState(EnemySP enemy) : base(EnemyState.Chase)
    {
        this.enemy = enemy;
    }

    public override void OnEnter(EnemyState from, FsmMessage msg)
    {
        Debug.Log("Chase state enter");
    }

    public override void OnUpdate(float deltaTime)
    {
        enemy.MoveTowardsPlayer();

        if (!enemy.IsPlayerInRange())
        {
            enemy.FSM.ChangeState(EnemyState.Idle);
        }
    }
}
