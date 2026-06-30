using UnityEngine;

public class PlayerTMP : MonoBehaviour
{
    private MiniGameBase buttonMashGame;
    private MiniGameBase dodgeBallGame;
    private void Start()
    {
        buttonMashGame = new ButtonMashGame();

        dodgeBallGame = new DodgeBallGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            buttonMashGame.StartGame();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            dodgeBallGame.StartGame();
        }
    }
}
