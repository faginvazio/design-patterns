using UnityEngine;

public class HitSoundPlayer : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private AudioSource hitSound;
    
    private void OnEnable()
    {
        playerHealth.OnHealthChanged += PlayHitSound;
    }
    private void OnDisable()
    {
        playerHealth.OnHealthChanged -= PlayHitSound;
    }

    private void PlayHitSound(int current, int max)
    {
        if (current < max)
        {
            hitSound.Play();
        }
    }
}
