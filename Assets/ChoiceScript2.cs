using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceScript2 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Incorrect! Writing the password on a sticky note increases the likelihood of unauthorised access and date breaches. Try again.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Incorrect! This is not recommended as long passwords can be easy to forget and can cause a decrease in productivity if forgotten. Try again.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Congratulations! You have successfully passed the Password Security Training Module! Proceed to the next module.";
        ChoiceMade = 3;
    }

    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
    }
}
