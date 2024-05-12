using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu; // Changed variable name from PauseMenu to pauseMenu
    public bool isPaused;
    public CursorManager cursorManager;
    public FirstPersonController playerController;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; // Corrected property name to Time.timeScale
        isPaused = true;
        playerController.SetMovementEnabled(false);
        cursorManager.ShowCursor();
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; // Corrected property name to Time.timeScale
        isPaused = false;
        playerController.SetMovementEnabled(true);
        cursorManager.HideCursor();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
