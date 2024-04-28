using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneSceneChange : MonoBehaviour
{
    public CursorManager cursorManager; // Reference to the CursorManager script

    // This method will be called when the object is clicked
    private void OnMouseDown()
    {
        // Load the scene with the specified name
        LoadScene("Phone");
    }

    // Method to load a scene by name
    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        // Show or hide cursor based on your logic
        if (sceneName == "Phone")
        {
            cursorManager.ShowCursor();
        }
        else
        {
            cursorManager.HideCursor();
        }
    }
}
