using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Function to show the cursor and unlock it
    public void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
    }

    // Function to hide the cursor and lock it at the center
    public void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor at the center
    }
}
