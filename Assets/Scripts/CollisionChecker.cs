using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour {

    public void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision Happened");
    }
}