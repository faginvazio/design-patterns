
using UnityEngine;

public abstract class GameFlow
{
    public void Run()
    {
        Initialize();
        Play();
        Cleanup();
    }

    protected abstract void Initialize();
    protected abstract void Play();
    protected virtual void Cleanup()
    {
        Debug.Log("Cleanup complete!");
    }
}
