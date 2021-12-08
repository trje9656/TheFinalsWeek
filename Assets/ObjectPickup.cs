using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPickup : MonoBehaviour
{
    public GameObject theEnemy;

    bool secondspawn = false;
    bool thirdspawn = false;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ScoreUpdate.keys += 1;
            Destroy(gameObject);
            print("destroyed");
        }

        if (ScoreUpdate.keys == 2 && !secondspawn)
        {
            Instantiate(theEnemy, new Vector3(4, -0.5f, 4), Quaternion.identity);
            secondspawn = true;
        }
        if (ScoreUpdate.keys == 3 && !thirdspawn)
        {
            Instantiate(theEnemy, new Vector3(0, -0.5f, 4), Quaternion.identity);
            thirdspawn = true;
        }

    }
}
