using SOEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    [SerializeField] private Health playerHealth;
    [SerializeField] private GameEventHealthChange onHealthChange;

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
}