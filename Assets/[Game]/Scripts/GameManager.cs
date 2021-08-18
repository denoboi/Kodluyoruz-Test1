using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public int levelCoinMultiplier = 2;

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

        int buildIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (!Application.CanStreamedLevelBeLoaded(buildIndex))
        {
            buildIndex = 0;
        }

        SceneManager.LoadScene(buildIndex);


    }
}
