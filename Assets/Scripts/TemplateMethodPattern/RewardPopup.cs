using UnityEngine;

public class RewardPopup : PopupBase
{
    protected override void RegisterButtons()
    {
        Debug.Log("register confirm button");
    }

    protected override void SetContent()
    {
        Debug.Log("reward content");
    }
}
