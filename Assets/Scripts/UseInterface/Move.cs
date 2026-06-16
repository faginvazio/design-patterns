using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private InputSystem_Actions inputSystem;
    private InputAction moveAction;

    private Vector2 moveInput;


    private float moveSpeed = 5f;

    private void Awake()
    {
        inputSystem = new InputSystem_Actions();
    }
    private void OnEnable()
    {
        moveAction = inputSystem.Player.Move;
        moveAction.Enable();
    }
    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
    private void OnDisable()
    {
        moveAction.Disable();
    }
}
