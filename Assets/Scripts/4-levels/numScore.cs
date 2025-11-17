using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class numScore : MonoBehaviour
{
    public NumberField source;    

    private TextMeshProUGUI textField;

    private void Awake()
    {
        textField = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (source != null && textField != null)
        {
            textField.text = source.GetNumber().ToString();
        }
    }
}
