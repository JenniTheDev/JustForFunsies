// Jenni
// Modification of RoboRyanTron's Unite 2017's
// game architecture with scriptable objects
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptable Object (Float)", menuName = "Scriptable Object (float)")]
public class FloatSO : ScriptableObject {
    [SerializeField] private float floatValue;

    public float FloatValue {
        get { return this.floatValue; }
        set { this.floatValue = value; }
    }

    public FloatSO(float floatValue) {
        this.floatValue = floatValue;
    }

    public static implicit operator float(FloatSO fV) {
        return fV.FloatValue;
    }
}