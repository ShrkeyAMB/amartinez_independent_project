using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorControl : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("DoorAnim", 0, 0.0f);
                gameObject.SetActive(true);
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (closeTrigger)
        {
            myDoor.Play("DoorAnimClose", 0, 0.0f);
            gameObject.SetActive(true);
        }
    }
}
