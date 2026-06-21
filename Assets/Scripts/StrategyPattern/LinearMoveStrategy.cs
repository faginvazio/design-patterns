using System.Runtime.InteropServices;
using UnityEngine;

public class LinearMoveStrategy : IMoveStrategy
{
    private Vector3 direction;
    private float speed;


    public LinearMoveStrategy(Vector3 direction, float speed)
    {
        this.direction = direction.normalized;
        this.speed = speed;
    }

    public void Move(Transform transform)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
