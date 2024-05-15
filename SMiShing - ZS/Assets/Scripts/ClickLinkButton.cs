using UnityEngine;
using TMPro;

public class ClickLinkButton : MonoBehaviour
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
            respondText.text = "You have clicked on a malicious link and your device is now at risk. Please try again.";
        }
        else
        {
            Debug.LogError("Respond Text object is not assigned!");
        }
    }
}
