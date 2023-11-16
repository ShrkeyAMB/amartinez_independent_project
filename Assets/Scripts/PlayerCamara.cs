using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamara : MonoBehaviour
{
    //Remember you need a Position attached to the player for this to work as its less buggy

    public float sensX;
    public float sensY;

    public Transform orientation;
    private PlayerMovement1 playerControl;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerControl = GameObject.Find("Player").GetComponent<PlayerMovement1>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);



        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        //if(playerControl.gameOver == true)
        
    }
}
