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

    //detect game object as player using tag and set the image to active if it comes in contact
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
