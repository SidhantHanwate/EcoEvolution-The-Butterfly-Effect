using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeExit : MonoBehaviour
{
    //scene 2 is village setting, we're loading it once the forest setting level has come to an end
    void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
