using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Health {
    [SerializeField] private float healthPoints;
    [SerializeField] private float startingHP;

    public Health(float startingHP) {
        this.startingHP = startingHP;
        this.healthPoints = startingHP;
    }

    public float HealthPoints {
        get { return this.healthPoints; }
    }

    public void AdjustHealth(float healthChange) {
        healthPoints += healthChange;
        CheckForDeath();
    }

    public void CheckForDeath() {
        if (healthPoints < 0) {
            
        } 
    }
}