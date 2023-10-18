using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaPickup : MonoBehaviour
{
    private PlayerMovement1 playerControl;
    private void Start()
    {
        playerControl=GameObject.Find("Player").GetComponent<PlayerMovement1>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerControl.pickUpSpeed = true;
            Debug.Log("Yummers");
            Destroy(gameObject);
        }
    }

}
