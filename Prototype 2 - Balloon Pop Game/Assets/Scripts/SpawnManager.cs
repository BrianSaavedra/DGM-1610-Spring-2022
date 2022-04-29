using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBallon", startDelay, spawnInterval);
    }



    void SpawnRandomBallon()
    {
        
        // Get a random positon on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,-2),10,0);
        // Pick a Random ballon from the ballon array 
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        // Spawn Random ballon at spawn location 
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);

        
    }
}
