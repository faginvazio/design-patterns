using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform transform;
    private Vector3 direction;
    private float distance;
    private Vector3 previousPosition;

    public MoveCommand(Transform transform, Vector3 direction, float distance)
    {
        this.transform = transform;
        this.direction = direction;
        this.distance = distance;
    }

    public void Execute()
    {
        previousPosition = transform.position;
        transform.position += direction * distance;
    }

    public void Undo()
    {
        transform.position = previousPosition;
    }
}
