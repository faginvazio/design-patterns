using UnityEngine;

public class JumpMoveStrategy : IMoveStrategy
{
    private Vector3 moveDirection;
    private float speed;
    private float jumpForce;

    public JumpMoveStrategy(Vector3 moveDirection, float speed, float jumpForce)
    {
        this.moveDirection = moveDirection.normalized;
        this.speed = speed;
        this.jumpForce = jumpForce;
    }

    public void Move(Transform transform)
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
        transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
    }
}
