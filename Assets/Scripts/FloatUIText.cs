using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatUIText : MonoBehaviour
{
    [SerializeField] private FloatSO floatNumber;
    [SerializeField] private TMP_Text toText;
    [SerializeField] private string textTitle;

    // Update is called once per frame
    private void FixedUpdate() {
        toText.text = $"{textTitle} {floatNumber.Value}";
    }
}
