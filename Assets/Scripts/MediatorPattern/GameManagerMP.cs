using UnityEngine;

public class GameManagerMP : MonoBehaviour
{
    private GameEventMediator mediator;


    [SerializeField] private PlayerMP player;
    [SerializeField] private AudioSystem audioSystem;
    [SerializeField] private CameraSystem cameraSystem;

    private void Awake()
    {
        mediator = new GameEventMediator();
        mediator.Register(audioSystem);
        mediator.Register(cameraSystem);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var deathEvent = new PlayerDiedEvent(player.transform.position, "fireball");
            mediator.Send(deathEvent);
        }
    }

    

}
