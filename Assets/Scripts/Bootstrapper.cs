using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private Score score;
    private Game game;
    [SerializeField] private InputHandler inputHandler;

    void Start()
    {
        score = new Score();
        game = new Game(score);
        inputHandler = new InputHandler(score);
    }
}
