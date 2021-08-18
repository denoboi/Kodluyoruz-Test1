using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnScoreChange.AddListener(GameStateCheck);
        EventManager.OnGameOver.AddListener(GameOver);
    }
    private void OnDisable()
    {
        EventManager.OnScoreChange.RemoveListener(GameStateCheck);
        EventManager.OnGameOver.RemoveListener(GameOver);
    }

   

    void GameStateCheck(int point)
    {
        
        if (point >= 5)
        {
            Debug.Log("Congrats");
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
    }
}
