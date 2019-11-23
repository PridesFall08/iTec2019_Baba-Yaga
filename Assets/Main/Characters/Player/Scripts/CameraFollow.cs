using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float rotX = 0, rotY = 0;
    public Camera camera;
    public float sensitivityX, sensitivityY;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
                Cursor.lockState = CursorLockMode.None;
            else
                Cursor.lockState = CursorLockMode.Locked;
        }
        
        rotX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivityX;
        rotY = Input.GetAxis("Mouse Y") * Time.deltaTime * -sensitivityY;

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            transform.Rotate(Vector3.up, rotX);
            camera.transform.RotateAround(transform.position, transform.right, rotY);
        }

    }
}
