using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class PlayerControllerV2 : MonoBehaviour {
    private PlayerControls controls;
    private Vector2 move;
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float jumpSpeed = -3.0f;
    private bool isPlayerGrounded;
    private Vector3 playerVelocity;

    private void Awake() {
        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable() {
        controls.Player.Enable();
    }

    private void OnDisable() {
        controls.Player.Disable();
    }

    private void Update() {
        // Should move to own method?
        //if (Input.GetButtonDown("Jump") && isPlayerGrounded) {
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * jumpSpeed);
        //}
        // how do you get gravity from the in game main setting of gravity?
        //playerVelocity.y += Physics.gravity * Time.deltaTime;
    }

    private void FixedUpdate() {
        Vector3 movement = new Vector3(move.x, 0.0f, move.y) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        //isPlayerGrounded = controls.isGrounded;
    }
}