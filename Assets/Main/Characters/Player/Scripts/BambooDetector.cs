using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooDetector : MonoBehaviour
{
    public Transform mouth;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Jump") && other.gameObject.CompareTag("Bamboo"))
        {
            other.transform.SetParent(mouth.transform);
            other.transform.position = mouth.transform.position;
            other.transform.rotation = mouth.transform.rotation;
            other.enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
