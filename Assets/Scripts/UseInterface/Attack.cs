using UnityEngine;

public class Attack : MonoBehaviour
{
    private int damage = 20;

    private void OnCollisionEnter(Collision collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
        if (damageable != null )
        {
            damageable.TakeDamage(damage);
        }
    }
}
