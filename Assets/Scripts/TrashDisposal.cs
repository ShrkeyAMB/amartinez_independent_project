using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDisposal : MonoBehaviour
{
    private TrashManager trashControl;
    private PlayerMovement1 playerControl;
    private void Start()
    {

        trashControl = GameObject.Find("TrashBagsSpawner").GetComponent<TrashManager>();
        playerControl = GameObject.Find("Player").GetComponent<PlayerMovement1>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trashControl.spawningTrash = true;
            playerControl.PickedUpTrash = 0;
        }
    }
}
