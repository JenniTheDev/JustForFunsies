using UnityEngine;
using SOEvents.Events;

public class HealthChange : MonoBehaviour {
    [SerializeField] private GameEventHealthChange onHealthChange;
    [SerializeField] private HealthChangeData healthChangeAmt;

    public HealthChangeData HealthChangeAmount { get => healthChangeAmt; }

    public void ActivateChange() {
        onHealthChange.Raise(new HealthChangeData(healthChangeAmt));
    }
}