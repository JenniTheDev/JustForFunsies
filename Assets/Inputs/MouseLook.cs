// From Unity's Shader Demo Project, with my modifications
#if ENABLE_INPUT_SYSTEM

using UnityEngine.InputSystem;

#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
    [SerializeField] private float mouseSensitivity = 100f;

    [SerializeField] private Transform playerBody;

    private float xRotation = 0f;
    // When I move these outside of Update, it breaks
    // private float mouseX = 0f;
    // private float mouseY = 0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //TODO: Ask Vast how to not do this in the Update loop
    private void Update() {
#if ENABLE_INPUT_SYSTEM
        // When I move these outside of Update, it breaks
        // TODO: find out why this breaks everything
        float mouseX = 0, mouseY = 0;

        if (Mouse.current != null) {
            var delta = Mouse.current.delta.ReadValue() / 15.0f;
            mouseX += delta.x;
            mouseY += delta.y;
        }
        if (Gamepad.current != null) {
            var value = Gamepad.current.rightStick.ReadValue() * 2;
            mouseX += value.x;
            mouseY += value.y;
        }

        mouseX *= mouseSensitivity * Time.deltaTime;
        mouseY *= mouseSensitivity * Time.deltaTime;
#else
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
#endif

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}