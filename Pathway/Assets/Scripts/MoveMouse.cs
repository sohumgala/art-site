using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
	// horizontal rotation speed
    public float horizontalSpeed = 5f;
    // vertical rotation speed
    public float verticalSpeed = 5f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;
 
    void Start()
    {
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked; 
    }
 
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;
 
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        //so you can't move your head like a freaky owl
 
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
