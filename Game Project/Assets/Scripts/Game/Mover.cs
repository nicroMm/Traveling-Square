using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
     [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        BackToMenu();
    }

    void PrintInstructions()
    {
        Debug.Log("Wlcome to the game !");
        Debug.Log("Move your player with arrow keys or WSAD.");
        Debug.Log("Don't hit the walls ! Good Luck !");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
            void BackToMenu()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }

}
