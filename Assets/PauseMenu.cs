using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePause = false;

    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject background;
    [SerializeField] GameObject control;

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
        pauseMenu.SetActive(false);
        background.SetActive(false);
        control.SetActive(true);
        Time.timeScale = 1f;
        isGamePause = false;
    }

    public void PauseGame() 
    {
        pauseMenu.SetActive(true);
        background.SetActive(true);
        control.SetActive(false);
        Time.timeScale = 0f;
        isGamePause = true;
    }

    public void QuitGame() 
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quit");
    }

}
