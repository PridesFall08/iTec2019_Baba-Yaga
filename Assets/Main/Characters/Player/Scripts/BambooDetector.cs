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
            bambooSlot.targetBamboo = other.gameObject.GetComponent<IBamboo>();
    }

    private void OnTriggerExit(Collider other)
    {
        bambooSlot.targetBamboo = null;
    }
}
