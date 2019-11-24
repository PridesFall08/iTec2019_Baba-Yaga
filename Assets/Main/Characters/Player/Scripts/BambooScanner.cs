using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooScanner : MonoBehaviour
{
    private BambooHolder _holder;
    
    private void Start()
    {
        _holder = GetComponentInParent<BambooHolder>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bamboo"))
            _holder.scannedBamboo = other.GetComponent<Bamboo>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bamboo"))
            _holder.scannedBamboo = null;
    }
}
