using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 11f;
    private Vector2 horizontalMovement;

    private void Update() {
        Vector3 horizontalVelocity = (transform.right * horizontalMovement.x + transform.forward * horizontalMovement.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
    }

    public void RecieveInput(Vector2 input) {
        horizontalMovement = input;
        Debug.Log(horizontalMovement);
    }
}