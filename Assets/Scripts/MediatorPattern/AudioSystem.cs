using UnityEngine;

public class AudioSystem : MonoBehaviour, IGameEventReceiver
{
    public void OnGameEvent(IGameEvent gameEvent)
    {
        if (gameEvent is PlayerDiedEvent)
        {
            Debug.Log("Sound: play death sound effect");
        }
    }
}
