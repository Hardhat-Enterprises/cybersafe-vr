using UnityEngine;
using TMPro;

public class ReportButton : MonoBehaviour
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
            respondText.text = "You have decided to report this SMS, please proceed to the IT Department";
        }
        else
        {
            Debug.LogError("Respond Text object is not assigned!");
        }
    }
}
