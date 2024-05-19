using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption1 ()
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Incorrect! Choosing a password with your personal information can be easy for an attacker to guess. Try again.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2 ()
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Incorrect! Even though using a combination of letter and numbers is recomended, less than 8 characters can be easy for an attacker to bruteforce. Try again.";
        ChoiceMade = 2;
    }

    void Update()
    {
     if (ChoiceMade >= 1) {
         Choice01.SetActive(false);
         Choice02.SetActive(false);
         Choice03.SetActive(false);
     }   
    }
}
