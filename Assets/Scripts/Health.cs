using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour {
    [SerializeField] private FloatSO healthPoints;
    [SerializeField] private FloatSO startingHP;
    [SerializeField] private UnityEvent damageEvent;
    [SerializeField] private UnityEvent deathEvent;

    private void Start() {
        healthPoints.SetValue(startingHP);
    }

    private void OnTriggerEnter(Collider other) {
        
    }


}
