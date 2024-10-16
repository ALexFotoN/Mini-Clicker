using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public Score score;
    public Game game;
    public InputHandler inputHandler;

    void Start()
    {
        score = new Score();
        game = new Game(score);
        inputHandler = new InputHandler(score);
    }
}
