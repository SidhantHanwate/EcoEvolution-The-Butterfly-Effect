using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main_menu : MonoBehaviour
{
  public void playGame()
  {
        // get the scene whicih is active presently and from the queue of scenes load the scene 
        // indexes in that queue are 0 based so you need to add 1 to it to use it here
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

  }
  // simple function for quitting the application
  public void QuitGame()
  {
    Debug.Log("Quit msg");
    Application.Quit();
  }
}
