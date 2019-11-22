using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooDetector : MonoBehaviour
{
    public Transform mouth;

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.tag);
        if (Input.GetButtonDown("Jump") && other.gameObject.CompareTag("Bamboo"))
        {
            
            other.transform.SetParent(mouth.transform);
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            other.transform.position = mouth.transform.position;
        }
    }
}
