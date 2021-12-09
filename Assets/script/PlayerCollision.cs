using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deadscreen;

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ScoreUpdate.keys += 1;
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            deadscreen.SetActive(true);

            
        }

    }

    public void QuitGame()
    {
        Application.Quit();
        
        Debug.Log("Quit");
    }

}
