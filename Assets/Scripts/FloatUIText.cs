using TMPro;
using UnityEngine;

public class FloatUIText : MonoBehaviour {
    [SerializeField] private FloatSO floatNumber;
    [SerializeField] private TMP_Text toText;
    [SerializeField] private string textTitle;

    private void FixedUpdate() {
        toText.text = $"{textTitle} {floatNumber}";
    }
}