using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Returns to the office environment, scene1. //
    public void GoToScene1()
    {
        SceneManager.LoadScene("PhScene1");
    }

    // Scene 2, email instructions. //
    public void GoToScene2()
    {
        SceneManager.LoadScene("PhScene2");
    }

    // Scene 3, email inbox with unread emails. //
    public void GoToScene3()
    {
        SceneManager.LoadScene("PhScene3");
    }

    // Scene 4, Google Drive email //
    public void GoToScene4()
    {
        SceneManager.LoadScene("PhScene4");
    }

    // Scene 5, Google Drive email red flag 1 - sender address //
    public void GoToScene5()
    {
        SceneManager.LoadScene("PhScene5");
    }

    // Scene 6, Google Drive email red flag 2 - link //
    public void GoToScene6()
    {
        SceneManager.LoadScene("PhScene6");
    }

    // Scene 7 //
    public void GoToScene7()
    {
        SceneManager.LoadScene("PhScene7");
    } 
    
    // Scene 8 //
    public void GoToScene8()
    {
        SceneManager.LoadScene("PhScene8");
    }  
    
    // Scene 9 //
    public void GoToScene9()
    {
        SceneManager.LoadScene("PhScene9");
    }
}
