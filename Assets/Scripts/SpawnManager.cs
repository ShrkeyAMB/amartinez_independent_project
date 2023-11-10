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
    private int spawnedPowerUpsCount;
    public float countDown = 5f;

    
    private PlayerMovement1 playerControl;

    private void Start()
    {

        playerControl = GameObject.Find("Player").GetComponent<PlayerMovement1>();

        SpawnPowerUps(1);





    }

    private void Update()
    {
        spawnedPowerUpsCount = FindObjectsOfType<SodaPickup>().Length;

        if (spawnedPowerUpsCount == 0)
        {
            SpawnPowerUps(1);
        }

        if (playerControl.gameOver == true)
        {
            
            Debug.Log("Spawning Has Stopped");
        }
    }

    

    void SpawnPowerUps(int powerUpSpeedCount)
    {
        for (int i = 0; i < powerUpSpeedCount; i++)
        {
            powerUpClones[0] = Instantiate(powerUpPrefabs[0], powerUpSpawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            powerUpClones[1] = Instantiate(powerUpPrefabs[1], powerUpSpawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }
}
