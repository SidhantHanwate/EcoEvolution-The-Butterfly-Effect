using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TMP_Text Score;
    public static int theScore;


    //simple method to update the score
    void Update()
    {
        Score.text = "Score: "+theScore;
    }
}
