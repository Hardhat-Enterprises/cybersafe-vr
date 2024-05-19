using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public CursorManager cursorManager;

    // Method to load a scene by name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        // Show or hide cursor based on your logic
        if (sceneName == "SMSOffice" || sceneName == "SWB")
        {
            cursorManager.HideCursor();
        }
        else
        {
            cursorManager.ShowCursor();
        }
    }
}