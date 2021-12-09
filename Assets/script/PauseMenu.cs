using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePause = false;

    public GameObject background;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isGamePause)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();
            }
        }
        if (isGamePause && Input.GetKeyDown(KeyCode.R)) 
        {
            ResumeGame();
        }
        if (isGamePause && Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
    }

    public void ResumeGame() 
    {
       
        background.SetActive(false);
        Time.timeScale = 1f;
        isGamePause = false;
    }

    public void PauseGame() 
    {
        
        background.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;
    }

    public void QuitGame() 
    {
        Application.Quit();
        
        Debug.Log("Quit");
    }

}
