using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private int score;
    private bool pause;
    [SerializeField] private TextMeshProUGUI pauseText, gameOverText;

    void Start()
    {
        pause = false;
        score = 0;
        gameOverText.gameObject.SetActive(false);
        pauseText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            pause = !pause;
            pauseText.gameObject.SetActive(!pauseText.gameObject.activeSelf);
        }

        if (pause) Time.timeScale = 0; else Time.timeScale = 1;
    }

    public void ScoreUp()
    {
        score++;
        print(score);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
