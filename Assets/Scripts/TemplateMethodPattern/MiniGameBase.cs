using UnityEngine;

public abstract class MiniGameBase : MonoBehaviour
{
    public void StartGame()
    {
        Setup();
        Play();
        End();
    }

    protected abstract void Setup();
    protected abstract void Play();
    protected virtual void End()
    {
        Debug.Log("base end");
    }
}
