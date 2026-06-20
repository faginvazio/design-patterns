using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SOLIDUI : MonoBehaviour
{
    [SerializeField] private Button sButton;
    [SerializeField] private Button oButton;
    [SerializeField] private Button lButton;
    [SerializeField] private Button iButton;
    [SerializeField] private Button dButton;

    [SerializeField] private TextMeshProUGUI description;

    private void Start()
    {
        sButton.onClick.AddListener(SRP);
        oButton.onClick.AddListener(OCP);
        lButton.onClick.AddListener(LSP);
        iButton.onClick.AddListener(ISP);
        dButton.onClick.AddListener(DIP);

        description.text = "";
    }

    private void SRP()
    {
        description.text = "Single Responsibility Principle";
    }
    private void OCP()
    {
        description.text = "Open Closed Principle";
    }
    private void LSP()
    {
        description.text = "Liskov Substitution Principle";
    }
    private void ISP()
    {
        description.text = "Interface Segregation Principle";
    }
    private void DIP()
    {
        description.text = "Dependency Inversion Principle";
    }
}
