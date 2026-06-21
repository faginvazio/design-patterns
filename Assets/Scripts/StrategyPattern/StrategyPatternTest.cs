using UnityEngine;

public class StrategyPatternTest : MonoBehaviour
{
    public CharacterController characterController;

    private void Start()
    {
        IMoveStrategy linearStrategy = new LinearMoveStrategy(Vector3.right, 5f);
        characterController.SetMoveStrategy(linearStrategy);
        Debug.Log("Initial linear move strategy");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IMoveStrategy jumpStrategy = new JumpMoveStrategy(Vector3.forward, 3f, 2f);
            characterController.SetMoveStrategy (jumpStrategy);
            Debug.Log("Jump move strategy");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            IMoveStrategy dodgeStrategy = new DodgeMoveStrategy(Vector3.left, 7f);
            characterController.SetMoveStrategy(dodgeStrategy);
            Debug.Log("Dodge move strategy");
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            IMoveStrategy linearStrategy = new LinearMoveStrategy(Vector3.right, 5f);
            characterController.SetMoveStrategy(linearStrategy);
            Debug.Log("Linear move strategy");
        }
    }
}
