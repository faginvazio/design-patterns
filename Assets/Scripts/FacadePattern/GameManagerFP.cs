using UnityEngine;

public class GameManagerFP : MonoBehaviour
{
    private GameOverFacade gameOverFacade;

    private void Start()
    {
        UIManagerFP uiManager = new UIManagerFP();
        SoundManagerFP soundManager = new SoundManagerFP();
        SaveManagerFP saveManager = new SaveManagerFP();
        PlayerControllerFP playerController = FindFirstObjectByType<PlayerControllerFP>();

        gameOverFacade = new GameOverFacade(uiManager, soundManager, saveManager, playerController);

    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        { 
            OnPlayerDied();
        }
    }


public void OnPlayerDied()
    {
        gameOverFacade.HandleGameOver();
    }
}
