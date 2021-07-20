using SOEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    [SerializeField] private Health playerHealth;
    [SerializeField] private GameEventHealthChange onHealthChange;
    [SerializeField] private PlayerState playerState; // Instead of being player, can be more generic so it's for any player/npc/enemy object

    private void OnTriggerEnter(Collider other) {
        FloatChangeEventHandler badStuff = other.gameObject.GetComponent<FloatChangeEventHandler>();

        if (badStuff != null) {
            playerHealth.AdjustHealth(badStuff.ChangeAmount.ChangeAmount);
            onHealthChange.Raise(new HealthChangeData(badStuff.ChangeAmount.ChangeAmount));
        }
    }

    public float GetCurrentHealth() {
        return this.playerHealth.HealthPoints;
    }

    public PlayerState GetCurrentState() {
        return this.playerState;
    }

    // set state
}