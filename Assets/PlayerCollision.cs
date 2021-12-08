using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public FirstPersonController movement;

    void OnCollisionEnter(Collision collisioninfo) 
    {
        if (collisioninfo.collider.tag == "Zombie") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
