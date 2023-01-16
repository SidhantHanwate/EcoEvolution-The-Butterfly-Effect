using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npc_trigger : MonoBehaviour
{

    // public Text DisplayTest;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        Image.SetActive(false);
    }   

    // recognize the game object in contact using tag assigned, here player
    //set dialog box canvas to active if player comes in contact with this NPC
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(true);
        }
    }

    //set it to false to make it disappear
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Image.SetActive(false);
        }
    }
}