using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TMPQuestion1 : MonoBehaviour
{
    public GameObject ScrollImage;
    void Start(){
        ScrollImage.SetActive (false);

    }

    void OnTriggerEnter(Collider Player){
        if(Player.gameObject.tag=="Player"){
        ScrollImage.SetActive (true);
        }
    }

    void OnTriggerExit(Collider Player){
        if(Player.gameObject.tag=="Player"){
        ScrollImage.SetActive (false );
        }
    }

}
