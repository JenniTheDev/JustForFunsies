using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    // Maybe I don't want this reference here
    [SerializeField] private Movement movement;

    private PlayerControls playerControls;
    private PlayerControls.PlayerActions playerAction;
    private Vector2 horizontalDir;

    private void Awake() {
        playerControls = new PlayerControls();
        playerAction = playerControls.Player;
        // playerActions.[Action].performed += context => do something
        // context is a variable
        playerAction.Move.performed += ctx => horizontalDir = ctx.ReadValue<Vector2>();
    }

    private void Update() {
        // I don't want this in Update
        //movement.RecieveInput(horizontalDir);
    }

    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDestroy() {
        playerControls.Disable();
    }
}