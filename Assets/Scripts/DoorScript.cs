using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision other)
    {
       
        transform.Rotate(new Vector3(0, -90, 0));
        Debug.Log("it worked");
    }
}
