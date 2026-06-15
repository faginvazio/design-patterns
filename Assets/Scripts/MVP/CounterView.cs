using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour, ICounterView
{

    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button incButton;
    [SerializeField] private Button resetButton;


    private CounterPresenter presenter;

    private void Awake()
    {
        presenter = new CounterPresenter(this, new CounterModel());

        incButton.onClick.AddListener(presenter.OnIncButtonClicked);
        resetButton.onClick.AddListener(presenter.OnResetButtonClicked);
    }

    public void UpdateCountText(int count)
    {
        if (countText != null)
        {
            countText.text = $"Count: {count}";
        }
    }
}
