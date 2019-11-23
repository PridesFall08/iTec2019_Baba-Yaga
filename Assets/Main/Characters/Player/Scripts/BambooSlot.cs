using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IBamboo))]
public class BambooSlot : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public IBamboo bittenBamboo = null;
    [HideInInspector] public IBamboo targetBamboo = null;
    public Transform Mouth;

    public void BiteBamboo()
    {
        playerMovement.speedMultiplier = targetBamboo.GetSpeedMultiplier();
    }

    public void DropBamboo()
    {
        playerMovement.speedMultiplier = targetBamboo.LetGo();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (bittenBamboo == null)
            {
                if (targetBamboo != null)
                    BiteBamboo();
            }
            else
                DropBamboo();
        }
    }
}
