using TMPro;
using UnityEngine;

// This script needs work and isn't done
public class UIHealthText : MonoBehaviour {
    [SerializeField] private float floatNumber;
    [SerializeField] private PlayerCharacter playerCharacter;

    [SerializeField] private TMP_Text toText;
    [SerializeField] private string textTitle;

    private void Start() {
        playerCharacter.GetCurrentHealth();
        UpdateHealthUI();
    }

    // Should be on event health change
    public void UpdateHealthUI() {
        floatNumber = playerCharacter.GetCurrentHealth();
        toText.text = $"{textTitle} {floatNumber}";
    }
}