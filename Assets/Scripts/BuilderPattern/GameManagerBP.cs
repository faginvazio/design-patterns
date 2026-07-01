using UnityEngine;

public class GameManagerBP : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private CharacterPreset foo;

    private void Start()
    {
        Character warrior = new CharacterBuilder()
            .SetName("Warrior")
            .SetHP(200)
            .SetWeapon("Sword")
            .SetArmor("Steel Armor")
            .Build();


        Debug.Log(warrior);
    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnEnemy();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reward();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Character characterFoo = CharacterFactory.BuildFromPreset(foo);
            Debug.Log(characterFoo);
        }
    }



    private void SpawnEnemy()
    {
        GameObject enemy = new EnemyBuilder()
            .SetPrefab(enemyPrefab)
            .SetPosition(new Vector3(2, 0, 0))
            .SetName("Red Dragon")
            .SetHP(300)
            .SetColor(Color.red)
            .Build();
    }




    private void Reward()
    {
        var reward = new RewardBuilder()
            .AddGold(500)
            .AddExp(1200)
            .AddItem("legenary sword")
            .AddItem("HP potion")
            .Build();

        Debug.Log(reward);
    }
}
