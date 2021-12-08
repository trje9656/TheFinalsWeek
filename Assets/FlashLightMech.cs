using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightMech : MonoBehaviour
{
    bool isOn = false;
    public GameObject lightSource;
    public bool failSafe = false;
    public AudioSource click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fkey"))
        {
            if (!isOn && !failSafe)
            {
                failSafe = true;
                lightSource.SetActive(true);
                click.Play();
                isOn = true;
                StartCoroutine(FailSafe());
            }
            if (isOn && !failSafe)
            {
                failSafe = true;
                lightSource.SetActive(false);
                click.Play();
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }
        
    }
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }

}
