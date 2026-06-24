using UnityEngine;

public class IdleState : FsmState<EnemyState>
{
    private EnemySP enemy;

    public IdleState(EnemySP enemy) : base(EnemyState.Idle)
    {
        this.enemy = enemy;
    }

    public override void OnEnter(EnemyState from, FsmMessage msg)
    {
        Debug.Log("Idle state enter");
    }

    public override void OnUpdate(float deltaTime)
    {
        if (enemy.IsPlayerInRange())
        {
            enemy.FSM.ChangeState(EnemyState.Chase);
        }
    }
}
