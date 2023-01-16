using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TMPQuestion1 : MonoBehaviour
{
    //keep the image inactive at start of the game
    public GameObject ScrollImage;
    void Start(){
        ScrollImage.SetActive (false);

    }

    //detect game object as player using tag and set the image to active if it comes in contact
    void OnTriggerEnter(Collider Player){
        if(Player.gameObject.tag=="Player"){
        ScrollImage.SetActive (true);
        }
    }

    //set the image back to inactive state  ones it leaves vicinity of the object
    void OnTriggerExit(Collider Player){
        if(Player.gameObject.tag=="Player"){
        ScrollImage.SetActive (false );
        }
    }

}
