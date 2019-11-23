using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBamboo : MonoBehaviour, IBamboo
{
    public Transform bitePoint, biter;
    public float speedMultiplier;
    private Transform oldParent, currentParent;
    
    public Transform GetBitePoint()
    {
        return bitePoint;
        /*trans
        bamboo.transform.SetParent(mouth);
        bamboo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        bamboo.transform.position = mouth.position;
        bamboo.transform.rotation = mouth.rotation;
        bamboo.GetComponent<Collider>().enabled = false;
        return speedMultiplier;*/
    }

    public float GetSpeedMultiplier()
    {
        return 0.5f;
    }

    public float LetGo()
    {
        bamboo.transform.SetParent(oldParent);
        bamboo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        bamboo.GetComponent<Collider>().enabled = true;
        bamboo = null;
        return 1f;
    }

    private void Update()
    {
        if (biter != null)
        {
            transform.position = biter.transform.position;
        }
    }
}
