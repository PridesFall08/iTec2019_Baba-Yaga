using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BambooDetector))]
public class BambooDetector : MonoBehaviour
{
    public BambooSlot bambooSlot;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bamboo"))
            bambooSlot.bambooOnGround = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        bambooSlot.bambooOnGround = null;
    }
}
