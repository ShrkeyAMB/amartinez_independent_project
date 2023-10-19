using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerTrigger : MonoBehaviour
{
    public float gameTime = 30f;
    private PlayerMovement1 playerControl;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameTime = 30f;
            Invoke("TimerPc", 0);
            Debug.Log("time Is Reset");
        }
    }

    private void Start()
    {
        playerControl = GameObject.Find("Player").GetComponent<PlayerMovement1>();
        
    }

    private void Update()
    {
        Invoke("TimerPc", 0);

        if (gameTime <= 0f)
        {
            playerControl.gameOver = true;
            CancelInvoke("TimerPc");
            Debug.Log("You Lost");
        }
    }

    private void TimerPc()
    {
        gameTime -= Time.deltaTime;
        Debug.Log(gameTime - Time.deltaTime);

    }
}
