using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    static public int score;
    TMP_Text scoreText;
    LastScore lastScore;
    void Start()
    {
        lastScore = FindObjectOfType<LastScore>();
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Less is better!";
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = "SCORE:" + score.ToString();
    }

}
