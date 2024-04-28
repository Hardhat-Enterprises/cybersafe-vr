using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitOffice : MonoBehaviour
{
    // Method to be called when the button is clicked
    public void OnExitOfficeButtonClick()
    {
        // Load the Office scene
        SceneManager.LoadScene("Office");
    }
}
