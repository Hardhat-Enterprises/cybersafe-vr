using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSMS : MonoBehaviour
{
    // Method to be called when the button is clicked
    public void OnExitSMSButtonClick()
    {
        // Load the Office scene
        SceneManager.LoadScene("SMSOffice");
    }
}
