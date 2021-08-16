using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnScoreChange.AddListener(GameStateCheck);
    }
    private void OnDisable()
    {
        EventManager.OnScoreChange.RemoveListener(GameStateCheck);
    }

    void GameStateCheck(int point)
    {
        
        if (point >= 5)
        {
            Debug.Log("Congrats");
        }
    }
}
