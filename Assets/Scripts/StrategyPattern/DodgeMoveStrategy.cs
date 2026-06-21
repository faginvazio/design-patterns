using UnityEngine;

public class DodgeMoveStrategy : IMoveStrategy
{
    private Vector3 dodgeDirection;
    private float dodgeSpeed;

    public DodgeMoveStrategy(Vector3 dodgeDirection, float dodgeSpeed)
    {
        this.dodgeDirection = dodgeDirection.normalized;
        this.dodgeSpeed = dodgeSpeed;
    }

    public void Move(Transform transform)
    {
        transform.Translate(dodgeDirection * dodgeSpeed * Time.deltaTime);
    }
}
