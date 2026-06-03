using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Toggle myToggle; // Reference to the Toggle component
    public GameObject targetObject; // Reference to the GameObject you want to toggle
    public Image Checkmark;

    private bool realState = false;

    private float lastEventTime = 0f;
    private const float minInterval = 0.05f; // 50 milliseconds debounce time

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Toggle Script Activated");

        myToggle.isOn = realState;
        targetObject.SetActive(realState);
        myToggle.onValueChanged.AddListener(HandleToggleChanged);
    }

    //void Update()
    //{
    //    Debug.Log("Toggle internal state: " + myToggle.isOn);
    //}
    void HandleToggleChanged(bool isOn)
    {
        if (Time.time - lastEventTime < minInterval)
            return;
        lastEventTime = Time.time;


        realState = !realState;

        myToggle.isOn = realState;

        targetObject.SetActive(realState);

        Checkmark.enabled = realState;

        Debug.Log("REAL TOGGLE STATE " + realState);

    }
}