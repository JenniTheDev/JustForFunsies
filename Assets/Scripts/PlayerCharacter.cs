using SOEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    [SerializeField] private Health playerHealth;
    [SerializeField] private GameEventHealthChange onHealthChange;

    private void OnCollisionEnter(Collision collision) {
        BadStuff badStuff = collision.gameObject.GetComponent<BadStuff>();
        if (badStuff != null) {
            playerHealth.AdjustHealth(badStuff.DamageAmount.ChangeAmount);
            onHealthChange.Raise(new HealthChangeData(badStuff.DamageAmount.ChangeAmount));
        }
    }
}