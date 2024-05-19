using UnityEngine;
using TMPro;

public class TypeEmailButton : MonoBehaviour
{
    public TMP_Text respondText; // Reference to the TextMeshPro Text object you want to change

    void Start()
    {
        // Manually assign the reference to the TextMeshPro Text component
        respondText = GameObject.Find("Respond")?.GetComponent<TMP_Text>();

        if (respondText == null)
        {
            Debug.LogError("Respond Text object is not found or TMP_Text component is missing!");
        }
    }

    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        // Change the text of the TextMeshPro Text object
        if (respondText != null)
        {
            respondText.text = "You have decided to type your email address, this was a phishing web page. BE MORE CAREFUL";
        }
        else
        {
            Debug.LogError("Respond Text object is not assigned!");
        }
    }
}
