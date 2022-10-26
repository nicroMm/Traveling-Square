using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LastScore : MonoBehaviour
{
    TMP_Text lastScore;
    int finalScore;
    private void Start() 
    {
        finalScore = ScoreBoard.score;
        lastScore = GetComponent<TMP_Text>();
        lastScore.text = "Your Socore:" + finalScore.ToString();
        
    }

}
