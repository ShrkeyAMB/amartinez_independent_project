using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] powerUpSpawnLocations;
    public GameObject[] powerUpPrefabs;
    public GameObject[] powerUpClones;

    public float timeToSpawn = 0;
    private int spawnedObjects;
    public float countDown = 5f;
    


    private void Start()
    {
        

        Invoke("SpawnPowerUps", 2 );
        spawnedObjects = 2;
        
        
        
    }

    private void Update()
    {
        Invoke("Spawning", 0);
    }

    void Spawning()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            spawnedObjects = 0;
        }
        if (spawnedObjects == 0)
        {
            Invoke("SpawnPowerUps", 2);
            spawnedObjects = 2;
            countDown = 5f;
        }
    }

    void SpawnPowerUps()
    {
        powerUpClones[0] = Instantiate(powerUpPrefabs[0], powerUpSpawnLocations[0].transform.position,Quaternion.Euler(0,0,0)) as GameObject;
        powerUpClones[1] = Instantiate(powerUpPrefabs[1], powerUpSpawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
