using UnityEngine;
using TMPro;

public class IgnoreButton : MonoBehaviour
{
    public TMP_Text respondText; // Reference to the TextMeshPro Text object you want to change

    void Start()
    {
        // Manually assign the reference to the TextMeshPro Text component
        respondText = GameObject.Find("Respond").GetComponent<TMP_Text>();
    }

    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        // Change the text of the TextMeshPro Text object
        if (respondText != null)
        {
            respondText.text = "You have not exposed your device to the possibly malicious site, but others may be at risk and reporting it may help to protect the workplace.";
        }
        else
        {
            Debug.LogError("Respond Text object is not assigned!");
        }
    }
}
