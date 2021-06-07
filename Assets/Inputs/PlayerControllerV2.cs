using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class PlayerControllerV2 : MonoBehaviour {
    private PlayerControls controls;
    private Vector2 move;
    [SerializeField] private float moveSpeed = 10.0f;

    private void Awake() {
        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;
    }

    private void SendMessage(Vector2 coordinates) {
        Debug.Log("Thumb stick coordinates " + coordinates);
    }

    private void OnEnable() {
        controls.Player.Enable();
    }

    private void OnDisable() {
        controls.Player.Disable();
    }

    private void FixedUpdate() {
        Vector3 movement = new Vector3(move.x, 0.0f, move.y) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}