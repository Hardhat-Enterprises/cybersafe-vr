using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderChangeScene : MonoBehaviour // Delcaring the public class, inherits from MonoBehaviour.
{
    public string scenename; // Declaring public string - holds the name of the scene to which the script should change to.

    void OnTriggerEnter(Collider other) // Called when the collider enters the trigger collier attached to the game object that this script is attached to.
    {
        if (other.CompareTag("Player")) // Checking that the collider which entered the trigger has the "player" tag.
        {
            SceneManager.LoadScene(scenename); // If the collider entering the trigger has the "player" tag, the next scene is loaded.
        }
    }
}
