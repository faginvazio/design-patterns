using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private IMoveStrategy moveStrategy;

    public void SetMoveStrategy(IMoveStrategy strategy)
    {
        moveStrategy = strategy;
    }

    private void Update()
    {
        if (moveStrategy != null)
        {
            moveStrategy.Move(transform);
        }
    }
}
