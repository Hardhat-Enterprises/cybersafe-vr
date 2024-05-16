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

    // Scene 6, Google Drive email red flag 2 - option for user to select y/n depending on whether they think link is safe //
    public void GoToScene6()
    {
        SceneManager.LoadScene("PhScene6");
    }

    // Scene 7, Google drive, when user thinks link does NOT lead to Google drive (correct) //
    public void GoToScene7()
    {
        SceneManager.LoadScene("PhScene7");
    } 
    
    // Scene 8, Google drive, when user thinks link DOES lead to Google drive (inorrect) //
    public void GoToScene8()
    {
        SceneManager.LoadScene("PhScene8");
    }  
    
    // Scene 9, Antivirus email //
    public void GoToScene9()
    {
        SceneManager.LoadScene("PhScene9");
    }

    // Scene 10, Antivirus email red flag 1 - the sender address //
    public void GoToScene10()
    {
        SceneManager.LoadScene("PhScene10");
    }

    // Scene 11, Antivirus email red flag 2 - the sense of urgency //
    public void GoToScene11()
    {
        SceneManager.LoadScene("PhScene11");
    }

    // Scene 12, Antivirus email red flag 3 - the URL (user prompted with y/n question) //
    public void GoToScene12()
    {
        SceneManager.LoadScene("PhScene12");
    }

    // Scene 13, Antivirus email red flag 3 - when user thinks the link does NOT look safe (correct) //
    public void GoToScene13()
    {
        SceneManager.LoadScene("PhScene13");
    }

    // Scene 14, Antivirus email - when user thinks URL is safe to click (incorrect) //
    public void GoToScene14()
    {
        SceneManager.LoadScene("PhScene14");
    }

    // Scene 15, Antivirus email - red flag 4, spelling and grammar errors //
    public void GoToScene15()
    {
        SceneManager.LoadScene("PhScene15");
    }

    // Scene 16, Anthony Smith email //
    public void GoToScene16()
    {
        SceneManager.LoadScene("PhScene16");
    }

    // Scene 17, Anthony Smith email red flag 1 - entire email content //
    public void GoToScene17()
    {
        SceneManager.LoadScene("PhScene17");
    }

    // Scene 18, Anthony Smith email, hint/giveup //
    public void GoToScene18()
    {
        SceneManager.LoadScene("PhScene18");
    }
}
