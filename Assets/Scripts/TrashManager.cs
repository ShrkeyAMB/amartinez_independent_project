using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public GameObject trashBagPrefab;
    private int CurrentTrashCount;
    public GameObject[] trashLocations;

    public float DelayInBetween = 15f;
    public float initialCount = 15f;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTrash(1);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTrashCount = FindObjectsOfType<TrashBagScript>().Length;
        if(CurrentTrashCount == 0)
        {
            DelayInBetween -= Time.deltaTime;
            Debug.Log(DelayInBetween - Time.deltaTime);
        }
        if(DelayInBetween <= 0)
        {
            waveNumber++;
            SpawnTrash(1 + waveNumber);
            DelayInBetween = initialCount--;
        }
    }

    void SpawnTrash(int trashCount)
    {
        for(int i = 0; i < trashCount; i++)
        {
            Instantiate(trashBagPrefab, trashLocations[Random.Range(0,13)].transform.position, Quaternion.Euler(-90f, 0f, 0f));
            
        }
    }
}
