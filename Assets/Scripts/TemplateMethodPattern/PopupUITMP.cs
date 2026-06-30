using UnityEngine;

public class PopupUITMP : MonoBehaviour
{
    [SerializeField] private WarningPopup warningPopup;
    [SerializeField] private RewardPopup rewardPopup;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        { 
            warningPopup.Open(); 
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            rewardPopup.Open();
        }
    }
}
