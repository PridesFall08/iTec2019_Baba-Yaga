using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public GameObject win, lose, button;

    private void Start()
    {
        GameObject.FindWithTag("Npc").GetComponent<NpcTester>().OnGameFailed += Lose;
        GameObject.FindWithTag("Npc").GetComponent<NpcTester>().OnGameSucceded += Win;
    }

    public void Win(object obj, EventArgs e)
    {
        win.SetActive(true);
        button.SetActive(true);
    }

    public void Lose(object obj, EventArgs e)
    {
        lose.SetActive(true);
        button.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
