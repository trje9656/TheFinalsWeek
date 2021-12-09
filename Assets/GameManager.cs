using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deadscreen;
    public GameObject winscreen;

    bool isend = false;
    bool iswin = false;
    void Update()
    {
        
        if (isend && Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }


        if(ScoreUpdate.keys == 4)
        {
            WinGame();
        }
    }

    public void EndGame() 
    {
        isend = true;
        Time.timeScale = 0;
        Debug.Log("GAME OVER");
        deadscreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quit");
    }

    public void WinGame()
    {
        iswin = true;
        Time.timeScale = 0;
        Debug.Log("GAME Win");
        winscreen.SetActive(true);

    }


}
