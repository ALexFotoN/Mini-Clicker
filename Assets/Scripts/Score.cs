using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int CurrentScore { get; set; }
    //public Action OnScoreChanged;

    public void DecrementScore()
    {
        CurrentScore--;
        //OnScoreChanged?.Invoke();
    }

    public void IncrementScore()
    {
        CurrentScore++;
        //OnScoreChanged?.Invoke();
    }
}
