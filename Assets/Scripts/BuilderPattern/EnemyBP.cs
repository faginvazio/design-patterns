using UnityEngine;

public class EnemyBP : MonoBehaviour
{
    [SerializeField] private int hp;
    public void Init(int hp)
    {
        this.hp = hp;
    }
}
