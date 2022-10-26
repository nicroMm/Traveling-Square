using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 1;
    ScoreBoard scoreBoard;
    private void Start() 
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
        scoreBoard.IncreaseScore(hits);
        }    
    }
}
