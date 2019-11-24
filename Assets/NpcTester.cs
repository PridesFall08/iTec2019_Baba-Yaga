using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTester : MonoBehaviour
{
    public event EventHandler OnGameFailed , OnGameSucceded;

    [SerializeField] private float timer = 3f;

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (timer <= 0)
        {
            if (other.gameObject.CompareTag("Tester"))
                OnGameFailed?.Invoke(this, EventArgs.Empty);
            else
                OnGameSucceded?.Invoke(this, EventArgs.Empty);
        }
    }
}
