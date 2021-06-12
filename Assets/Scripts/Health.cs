using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour {
    [SerializeField] private float healthPoints;
    [SerializeField] private FloatSO startingHP;

    public float HealthValue {
        get { return this.healthPoints; }
        set { this.healthPoints = value; }
    }

    private void Start() {
        healthPoints = startingHP;
    }

    private void OnTriggerEnter(Collider collider) {
        AdjustHealth(collider.GetComponent<HealthChangeData>());
    }

    private void AdjustHealth(HealthChangeData healthChange) {
        healthPoints += healthChange.ChangeAmount;
    }
}