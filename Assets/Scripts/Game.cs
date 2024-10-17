using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    private Score score;

    public Game(Score score)
    {
        this.score = score;
        StartGame();
    }

    private void StartGame()
    {
        score.CurrentScore = 5;
        Debug.Log("Game started. Score: " + score.CurrentScore);
    }

    public void ExitGame()
    {
        score.CurrentScore = 0;
        Debug.Log("Game ended. Score reset.");
        Application.Quit();
    }
}
