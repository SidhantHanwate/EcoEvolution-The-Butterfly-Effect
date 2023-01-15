using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TMPQuestion1 : MonoBehaviour
{
    public GameObject popUp;
    void Start(){
        popUp.SetActive (false);

    }

    void OnTriggerEnter(Collider Player){
        if(Player.gameObject.tag=="Player"){
        popUp.SetActive (true);
        }
    }

    void OnTriggerExit(Collider Player){
        if(Player.gameObject.tag=="Player"){
        popUp.SetActive (false );
        }
    }

}
