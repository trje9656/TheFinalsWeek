using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //singleton

    #region Singleton
    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Zombie") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
