using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour {
    [SerializeField] private float healthPoints;
    [SerializeField] private FloatSO startingHP;
    [SerializeField] private UnityEvent damageEvent;
    [SerializeField] private UnityEvent deathEvent;

    public float HealthValue {
        get { return this.healthPoints; }
        set { this.healthPoints = value; }
    }

    private void Start() {
        healthPoints = startingHP;
    }

    private void OnTriggerEnter(Collider other) {
    }
}