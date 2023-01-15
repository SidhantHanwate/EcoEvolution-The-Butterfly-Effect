using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColliderTestDecision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + "has collided with the object "+ other.gameObject.name);
    }

        void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "has triggered "+ other.gameObject.name);
    }
}