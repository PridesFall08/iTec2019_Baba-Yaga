using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private Animator anim;
    public float secondsPerDay = 0f;
    public GameObject rain, tester;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("DayDuration", secondsPerDay);
    }

    public void TimesUp()
    {
        print("EndGame!");
        rain.SetActive(true);
        tester.SetActive(true);
    }
}
