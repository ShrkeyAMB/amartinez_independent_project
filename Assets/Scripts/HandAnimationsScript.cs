using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimationsScript : MonoBehaviour
{
    private Animator animPlayer;
    private PlayerMovement1 playerControl;

    private void Start()
    {
        animPlayer = GetComponent<Animator>();

        playerControl = GameObject.Find("Player").GetComponent<PlayerMovement1>();

    }

    private void Update()
    {
        if(playerControl.pickUpSpeed == true)
        {
            animPlayer.SetBool("SodaPickUp", true);
        }
        if (playerControl.pickUpSpeed == false)
        {
            animPlayer.SetBool("SodaPickUp", false);
        }
    }
}
