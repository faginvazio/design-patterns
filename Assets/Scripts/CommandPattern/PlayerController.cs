using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float moveDistance = 1f;
    public float speed = 5f;

    private CommandManager commandManager;

    [SerializeField] private Transform playerTransform;


    private InputSystem_Actions inputSystemActions;
    private InputAction moveAction;
    private InputAction previousAction;
    private Vector2 moveInput;

    private void Awake()
    {
        inputSystemActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        moveAction = inputSystemActions.Player.Move;
        previousAction = inputSystemActions.Player.Previous;
        moveAction.Enable();
        previousAction.Enable();

    }

    private void OnDisable()
    {
        moveAction.Disable();
        previousAction.Disable();
    }

    private void Start()
    {
        commandManager = FindFirstObjectByType<CommandManager>();
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        if (moveInput != Vector2.zero) 
        {
            ICommand move = new MoveCommand(playerTransform, moveInput * Time.deltaTime * speed, moveDistance);
            commandManager.ExecuteCommand(move);
        }
        



        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    ICommand moveUP = new MoveCommand(playerTransform, Vector3.up, moveDistance);
        //    commandManager.ExecuteCommand(moveUP);
        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    ICommand moveDown = new MoveCommand(playerTransform, Vector3.down, moveDistance);
        //    commandManager.ExecuteCommand(moveDown);
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    ICommand moveLeft = new MoveCommand(playerTransform, Vector3.left, moveDistance);
        //    commandManager.ExecuteCommand(moveLeft);
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    ICommand moveRight = new MoveCommand(playerTransform, Vector3.right, moveDistance);
        //    commandManager.ExecuteCommand(moveRight);
        //}

        if (previousAction.WasPressedThisFrame())
        {
            commandManager.UndoCommand();
            commandManager.UndoCommand();
            commandManager.UndoCommand();
        }

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    commandManager.UndoCommand();
        //}
    }
}
