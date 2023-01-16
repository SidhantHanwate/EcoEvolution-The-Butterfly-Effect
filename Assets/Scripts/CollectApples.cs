using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectApples : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("theScore: "+ScoringSystem.theScore);
        ScoringSystem.theScore += 10;
        Destroy(gameObject);
    }
}
