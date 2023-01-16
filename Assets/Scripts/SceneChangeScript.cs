using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    //scene 1 is city setting, we're loading it once the forest setting level has come to an end
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1); 
    }
}