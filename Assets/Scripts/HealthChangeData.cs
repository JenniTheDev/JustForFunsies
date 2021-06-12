public struct HealthChangeData {
    private float changeAmount;

    public HealthChangeData(float changeAmount) {
        this.changeAmount = changeAmount;
    }

    public float ChangeAmount { get => changeAmount; }
}