using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePopScript : MonoBehaviour
{

    // public Text DisplayTest;
    public GameObject Image;
    void Start()
    {
        Image.SetActive(false);
    }   

    //detect game object by its tag, here it's the player we wish to interact with. Set the image to active as it comes in vicinty of the object
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(true);
        }
    }

       //set the image back to inactive state  ones it leaves vicinity of the object
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(false);
        }
    }
}
