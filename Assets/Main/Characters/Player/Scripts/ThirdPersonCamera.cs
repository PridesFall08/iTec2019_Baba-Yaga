using System;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
    public GameObject target;
    public float damping;
    public Vector2 sensitivity;
    public Vector3 offset = default;

    private float mouseX;
     
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (offset == default)
            offset = target.transform.position - transform.position;
    }

    private void Update()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            mouseX = Input.GetAxis("Mouse X");
            target.transform.Rotate(Vector3.up, mouseX * sensitivity.x * Time.deltaTime);
            transform.localPosition = offset;
            transform.LookAt(target.transform);
            if (Input.GetButtonDown("Cancel"))
                Cursor.lockState = CursorLockMode.None;
        } else if (Input.GetButtonDown("Cancel"))
            Cursor.lockState = CursorLockMode.Locked;
    }
}