using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class BambooSlot : MonoBehaviour
{
    public GameObject bamboo = null;
    [HideInInspector] public GameObject bambooOnGround = null;
    public Transform Mouth;
    private Transform oldParent;

    public void EquipBamboo(GameObject bamboo)
    {
        this.bamboo = bamboo;
        oldParent = bamboo.transform.parent;
        bamboo.transform.SetParent(Mouth);
        bamboo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        bamboo.transform.position = Mouth.position;
        bamboo.transform.rotation = Mouth.rotation;
        bamboo.GetComponent<Collider>().enabled = false;
    }

    public void DropBamboo()
    {
        bamboo.transform.SetParent(oldParent);
        bamboo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        bamboo.GetComponent<Collider>().enabled = true;
        bamboo = null;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (bamboo == null && bambooOnGround != null)
                EquipBamboo(bambooOnGround);
            else
                DropBamboo();
        }
    }
}
