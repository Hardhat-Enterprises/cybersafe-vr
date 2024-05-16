using UnityEngine;
using UnityEngine.SceneManagement;

public class SMiShScene : MonoBehaviour
{
    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        // Load the Office scene
        SceneManager.LoadScene("SMSOffice");
    }
}
