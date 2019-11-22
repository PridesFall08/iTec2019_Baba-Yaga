using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey("w"))
            transform.position += Vector3.up * Time.deltaTime * speed;
        if(Input.GetKey("s"))
            transform.position += Vector3.right * Time.deltaTime * speed;
        if (Input.GetKey("z"))
            transform.position += Vector3.down * Time.deltaTime * speed;
        if (Input.GetKey("a"))
            transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
