// Jenni
// Modification of RoboRyanTron's Unite 2017's
// game architecture with scriptable objects
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Float Change Amount")]
public class FloatChangeAmount : ScriptableObject {

    [Range(-100f, 100f)]
    [SerializeField] private float changeAmount;

    public float ChangeAmount {
        get { return this.changeAmount; }
        set { this.changeAmount = value; }
    }

    public static implicit operator float(FloatChangeAmount fV) {
        return fV.ChangeAmount;
    }
}