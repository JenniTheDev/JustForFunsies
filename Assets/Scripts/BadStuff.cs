using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadStuff : MonoBehaviour {
    [SerializeField] private FloatChangeAmount damageAmount;

    public FloatChangeAmount DamageAmount { get => damageAmount; }
}