using UnityEngine;

public class GameOverFacade
{
    private UIManagerFP uiManager;
    private SoundManagerFP soundManager;
    private SaveManagerFP saveManager;
    private PlayerControllerFP playerController;

    public GameOverFacade(UIManagerFP uiManager, SoundManagerFP soundManager, SaveManagerFP saveManager, PlayerControllerFP playerController)
    {
        this.uiManager = uiManager;
        this.soundManager = soundManager;
        this.saveManager = saveManager;
        this.playerController = playerController;
    }

    public void HandleGameOver()
    {
        playerController.DisableControl();
        soundManager.PlayDeathSound();
        saveManager.SaveGame();
        uiManager.ShowGameOverUI();

        Debug.Log("complete game over process");
    }
}
