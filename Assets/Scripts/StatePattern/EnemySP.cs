using UnityEngine;

public class EnemySP : MonoBehaviour
{

    public StateMachine<EnemyState> FSM;
    public bool IsPlayerInRange()
    {
        return true;
    }

    public void MoveTowardsPlayer()
    {
        Debug.Log("Enemy move towards player");
    }
}
