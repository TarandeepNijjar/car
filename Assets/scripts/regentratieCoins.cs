using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class regentratieCoins : MonoBehaviour {
    [SerializeField]

    
    public GameObject[] enemy;
    public float spawnTime = 3f;
    public Transform spawnPoints;
    

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime,/* Random.Range(0, 6)*/1f);
    }

    void Spawn()
    {
        //if (!Player)
        //{
        //    return;
        //}

        //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);

        Vector3 EnemyPos = new Vector3(Random.Range(-1.2f, -1.199f), Random.Range(4.5f,160f), spawnPoints.transform.position.z);
        Instantiate(enemy[enemyIndex], EnemyPos, spawnPoints.rotation);


        enemyIndex = Random.Range(0, enemy.Length);
        EnemyPos = new Vector3(Random.Range(1f, 1.02f), Random.Range(4.5f, 160f), spawnPoints.transform.position.z);
        Instantiate(enemy[enemyIndex], EnemyPos, spawnPoints.rotation);
    }
}