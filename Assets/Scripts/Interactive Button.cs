using UnityEngine;
using UnityEngine.UI;

public class InteractiveButton : MonoBehaviour
{
    public Button button; // Reference to the Button component

    void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Add a listener to the button's onClick event
        button.onClick.AddListener(ButtonClicked);
    }

    // This method will be called when the button is clicked
    void ButtonClicked()
    {
        Debug.Log("Button Clicked!");
        // Add your custom code here to handle the button click event
    }
}