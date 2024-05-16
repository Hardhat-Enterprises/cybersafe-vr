using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChangeScene : MonoBehaviour // Declaring the public class ButtonChangeScene, inherits from MonoBehaviour.
{
    public string sceneName; // Declaring public string variable named sceneName. Holds the name of the scene to which the script should change.

    public void GoToNextScene() // Declaring a public method - method called when button associated w/ script is clicked.
    {
        SceneManager.LoadScene(sceneName); // Loads the new scene - which ever scene is stored in the sceneName variable. 
    }
}