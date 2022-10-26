using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenu : MonoBehaviour
{
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            ScoreBoard.score = 0;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        ScoreBoard.score = 0;
    }
}
