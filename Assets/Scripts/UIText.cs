using TMPro;
using UnityEngine;

// This script needs work and isn't done
public class UIText : MonoBehaviour {
    [SerializeField] private float floatNumber;
    [SerializeField] private GameObject player;

    [SerializeField] private TMP_Text toText;
    [SerializeField] private string textTitle;

    // Should be on event health change
    private void FixedUpdate() {
        floatNumber = player.GetComponent<Health>().HealthValue;
        toText.text = $"{textTitle} {floatNumber}";
    }
}