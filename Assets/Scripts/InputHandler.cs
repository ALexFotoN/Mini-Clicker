using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Score score;
    private Game game;

    public InputHandler(Score score)
    {
        this.score = score;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            game.ExitGame();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.CompareTag("DecrementObject"))
                {
                    score.DecrementScore();
                }
                else if (hit.transform.CompareTag("IncrementObject"))
                {
                    score.IncrementScore();
                }
            }
        }
    }
}
