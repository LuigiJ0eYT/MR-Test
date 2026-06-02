using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private TMP_Text valueText;
    [SerializeField] private Slider mySlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (mySlider == null || valueText == null)
        {
            Debug.LogError("Slider or Text reference is not set in the inspector.");
            enabled = false;
            return;
        }
        UpdateText(mySlider.value);

        mySlider.onValueChanged.AddListener(OnSliderValueChanged);
        Debug.Log("Inital slider value: " + mySlider.value);
    }

    private void OnSliderValueChanged(float newValue)
    {
        Debug.Log("Slider value changed to: " + newValue);

        UpdateText(newValue);
    }

    private void UpdateText(float currentValue)
    {
        valueText.text = currentValue.ToString("0.00");
    }
}
