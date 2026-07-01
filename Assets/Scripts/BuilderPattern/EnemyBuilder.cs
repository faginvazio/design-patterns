using UnityEngine;

public class EnemyBuilder
{
    private GameObject prefab;
    private Vector3 spawnPosition;
    private string enemyName;
    private int hp;
    private Color color = Color.white;


    public EnemyBuilder SetPrefab(GameObject prefab)
    {
        this.prefab = prefab;
        return this;
    }

    public EnemyBuilder SetPosition(Vector3 spawnPosition)
    {
        this.spawnPosition = spawnPosition;
        return this;
    }

    public EnemyBuilder SetName(string enemyName)
    { 
        this.enemyName = enemyName;
        return this;
    }

    public EnemyBuilder SetHP(int hp)
    {
        this.hp = hp;
        return this;
    }

    public EnemyBuilder SetColor(Color color)
    {
        this.color = color;
        return this;
    }


    public GameObject Build()
    {
        GameObject go = GameObject.Instantiate(prefab, spawnPosition, Quaternion.identity);
        go.name = enemyName;
        var enemy = go.GetComponent<EnemyBP>();
        enemy.Init(hp);        
        go.transform.GetChild(0).GetComponent<Renderer>().material.color = color;
        return go;
    }
}
