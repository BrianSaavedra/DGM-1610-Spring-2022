using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn: MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }



    void SpawnRandomEnemy()
    {
        
        
        Vector3 spawnPos = new Vector3(Random.Range(-0.27f,20),0,0);
        
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        
    }
}
