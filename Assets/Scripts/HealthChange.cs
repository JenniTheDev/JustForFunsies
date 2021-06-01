using UnityEngine;
using SOEvents.Events;

public class HealthChange : MonoBehaviour {
    [SerializeField] private GameEventHealthChange onHealthChange;
    [SerializeField] private float healthChangeAmt;
    [SerializeField] private AudioClip soundEffect;

    public float HealthChangeAmount { get => healthChangeAmt; }
    public AudioClip SoundEffect { get => soundEffect; }

    public void ActivateChange() {
        onHealthChange.Raise(this);
    }
}