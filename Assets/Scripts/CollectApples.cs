using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectApples : MonoBehaviour
{
    //add 10 points to the score when the player collects an apple and destroy the object to avoid multiple contacts
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("theScore: "+ScoringSystem.theScore);
        ScoringSystem.theScore += 10;
        Destroy(gameObject);
    }
}
