using UnityEngine;
using TMPro;

public class ClickLogoButton : MonoBehaviour
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
            respondText.text = "You have decided to click the PayPal logo to redirect the web page. Please review URL, this is a malicious web page.";
        }
        else
        {
            Debug.LogError("Respond Text object is not assigned!");
        }
    }
}
