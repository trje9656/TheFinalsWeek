using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPickup : MonoBehaviour
{
    public int keys;
    public GameObject keyText;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            keys += 1;
            keyText.GetComponent<Text>().text = "Keys: " + keys + "/4";

            Destroy(gameObject);
        }
            
    }
}
