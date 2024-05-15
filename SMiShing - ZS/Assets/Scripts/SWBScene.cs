using UnityEngine;
using UnityEngine.SceneManagement;

public class SWBScene : MonoBehaviour
{
    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        Debug.Log("Button Clicked!"); // Add this line for debugging
        // Load the Office scene
        SceneManager.LoadScene("SWB");
    }
}
