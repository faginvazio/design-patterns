using UnityEngine;

public class WarningPopup : PopupBase
{
    protected override void RegisterButtons()
    {
        Debug.Log("register close button");
    }

    protected override void SetContent()
    {
        Debug.Log("set warning content");
    }
}
