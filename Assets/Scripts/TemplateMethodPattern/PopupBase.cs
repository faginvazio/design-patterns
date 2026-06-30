using UnityEngine;

public abstract class PopupBase : MonoBehaviour
{
    public void Open()
    {
        PlayOpenAnimation();
        SetContent();
        RegisterButtons();
    }

    protected virtual void PlayOpenAnimation()
    {
        Debug.Log("basic popup animation play");
    }

    protected abstract void SetContent();
    protected abstract void RegisterButtons();
}
