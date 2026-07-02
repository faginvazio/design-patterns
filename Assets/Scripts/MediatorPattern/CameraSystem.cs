using UnityEngine;

public class CameraSystem : MonoBehaviour, IGameEventReceiver
{
    public void OnGameEvent(IGameEvent gameEvent)
    {
        if (gameEvent is PlayerDiedEvent playerDied)
        {
            Debug.Log($"Camera: Player {playerDied.deathPosition} died, zoom out");
        }
    }
}
