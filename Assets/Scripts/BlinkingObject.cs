using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingObject : MonoBehaviour
{
    public float blinkInterval = 0.5f; // This sets the interval for how fast the object 'blinks'
    private bool isVisible = true; // This is used to track the blinking/invisibility state of the object

    void Start()
    {
        InvokeRepeating("ToggleVisibility", 0f, blinkInterval); // This invokes the ToggleVisibility function, using the specified blink interval
    }

    void ToggleVisibility() // This is used to toggle the visiblity of the game object
    {
        isVisible = !isVisible; // Inverting the isVisible flag
        gameObject.SetActive(isVisible); // This is setting the game objects active state based on the isVisible flag
    }
}
