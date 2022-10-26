using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
            ScoreBoard.score = 0;
        }
    }
    public void playAgain()
    {
        SceneManager.LoadScene(1);
        ScoreBoard.score = 0;
    }  
}
