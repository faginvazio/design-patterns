using UnityEngine;

public class DamageLogger : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    private void OnEnable()
    {
        playerHealth.OnHealthChanged += LogHealth;
    }

    private void OnDisable()
    {
        playerHealth.OnHealthChanged -= LogHealth;
    }

    private void LogHealth(int current, int max)
    {
        Debug.Log($"[LOG] health changed: {current}/{max}");
    }
}
