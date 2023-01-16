using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePopScript : MonoBehaviour
{

    // public Text DisplayTest;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        Image.SetActive(false);
    }   

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(true);
        }
    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(false);
        }
    }
}
