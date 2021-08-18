using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text ScoreText1;
    //public Text ScoreText1
    //{
    //    get
    //    {
    //        if (scoreText == null)
    //        {
    //            scoreText.GetComponent<Text>();
    //        }
    //        return scoreText;
    //    }
    //}
    public int point = 0;
    private void OnEnable()
    {
        EventManager.OnCoinPickUp.AddListener(UpdateScoreText);

    }

    //obje deaktive edildiginde(set active = false oldugunda) OnDisable cagrilacak.
    private void OnDisable()
    {
        EventManager.OnCoinPickUp.RemoveListener(UpdateScoreText);
    }

    void UpdateScoreText()
    {
        point += GameManager.Instance.levelCoinMultiplier;
        ScoreText1.text = "Score: " + point;
        EventManager.OnScoreChange.Invoke(point);
    }







}
