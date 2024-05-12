using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCSceneChange : MonoBehaviour
{
    public CursorManager cursorManager; //showing reference to the cursor manager script 

    //This method will execute when the object is clicked 
    private void OnMouseDown()
    {
        //load specific scene 
        LoadScene("UI Environment");
    }

    //Method to load a scene by listed name
    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        if (sceneName == "UI Environment")
        {
            cursorManager.ShowCursor();
        }
        else
        {
            cursorManager.HideCursor();
        }
    }
}
