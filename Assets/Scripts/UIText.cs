using TMPro;
using UnityEngine;

// This script needs work and isn't done
public class UIText : MonoBehaviour {
    [SerializeField] private float floatNumber;
    [SerializeField] private GameObject player;

    [SerializeField] private TMP_Text toText;
    [SerializeField] private string textTitle;

    private void Start() {
    }

    // Should be on event health change
    public void UpdateHealthUI() {
        floatNumber = player.GetComponent<Health>().HealthValue;
        toText.text = $"{textTitle} {floatNumber}";
    }
}