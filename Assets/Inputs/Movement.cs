using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 11f;
    [SerializeField] private float gravity = -25f;
    private LayerMask groundMask;
    private Vector2 horizontalMovement;
    private Vector3 verticalVelocity = Vector3.zero;
    private bool isGrounded;

    private void Update() {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded) {
            verticalVelocity.y = 0;
        }

        // I don't think this is right, it makes player go in circles
        Vector3 horizontalVelocity = (transform.right * horizontalMovement.x + transform.forward * horizontalMovement.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void RecieveInput(Vector2 input) {
        horizontalMovement = input;
        // Debug.Log(horizontalMovement);
    }
}