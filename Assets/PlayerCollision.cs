using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ScoreUpdate.keys += 1;
            FindObjectOfType<GameManager>().EndGame();

        }



    }
}
