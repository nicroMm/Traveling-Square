using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour
{
    public void PlayGame()
    {
            SceneManager.LoadScene(1);
            ScoreBoard.score = 0;
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
            ScoreBoard.score = 0;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
