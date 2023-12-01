using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private bool pause;
    void Start()
    {
        pause = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause")) pause = !pause;

        if (pause) Time.timeScale = 0; else Time.timeScale = 1;
    }
}
