using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterspawner : MonoBehaviour
{
    public GameObject monster2;
    public GameObject monster3;
    bool secondspawn = false;
    bool thirdspawn = false;

    // Start is called before the first frame update
    void Start()
    {
        monster2.SetActive(false);
        monster3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(ScoreUpdate.keys == 2 && !secondspawn)
        {
            monster2.SetActive(true);
            secondspawn = true;
        }

        if(ScoreUpdate.keys == 3 && !thirdspawn)
        {
            monster3.SetActive(true);
            thirdspawn = true;
        }
    }
}
