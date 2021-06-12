using UnityEngine;
using SOEvents.Events;

public class HealthChange : MonoBehaviour {
    [SerializeField] private GameEventHealthChange onHealthChange;
    [SerializeField] private float healthChangeAmt;

    public void ActivateChange() {
        onHealthChange.Raise(new HealthChangeData(healthChangeAmt));
    }
}