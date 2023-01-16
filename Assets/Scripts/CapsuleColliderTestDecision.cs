    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColliderTestDecision : MonoBehaviour
{
    //detect collsion with game object other
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + "has collided with the object "+ other.gameObject.name);
    }

    //isTrigger is on so, it acts as a triggering rigid body

        void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "has triggered "+ other.gameObject.name);
    }
}