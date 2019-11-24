using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo : MonoBehaviour
{
    [SerializeField] private float _speedMultiplier = 1;
    
    public virtual void Attach(Transform mouth) { }

    public virtual void Detach(Transform mouth) { }

    public float GetSpeedMultiplier()
    {
        return _speedMultiplier;
    }
}
