// Jenni
// Modification of RoboRyanTron's Unite 2017's
// game architecture with scriptable objects
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptable Object (Float)", menuName = "Scriptable Object (float)")]
public class FloatSO : ScriptableObject {
    public float Value;

    public void SetValue(float value) {
        Value = value;
    }

    public void SetValue(FloatSO value) {
        Value = value.Value;
    }

    public void ApplyChange(float amount) {
        Value += amount;
    }

    public void ApplyChange(FloatSO amount) {
        Value += amount.Value;
    }
}