using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public FirstPersonController playerController;
    public CursorManager cursorManager; // Reference to the CursorManager script

    void Start()
    {
        pauseMenu.SetActive(false);
        ResumeGame(); // Ensure the game starts unpaused
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        playerController.SetMovementEnabled(false);
        cursorManager.ShowCursor(); // Show the cursor when pausing
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        playerController.SetMovementEnabled(true);
        cursorManager.HideCursor(); // Hide the cursor when resuming
    }

    public void ReturnMenu()
    {
        // Load the Office scene
        SceneManager.LoadScene("MainMenu");
    }
}
