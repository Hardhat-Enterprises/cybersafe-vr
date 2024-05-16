using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour // Declaring public class
{
    public Color highlightColor = Color.blue; // Declaring public variable highlightColor - initialized with the color blue
    private Color originalColor; // Variable stores original color of the GameObject before it was highlighted
    private Renderer objectRenderer; // Stores a reference to the renderer component of the game object
    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Retrieves the renderer component attached to the same game object, and assigns it to the objectRenderer variable
        originalColor = objectRenderer.material.color; // Retrieves current color of the objects material
    }
    void OnMouseEnter() // Called when users mouse pointer enters the game objects collider
    {
        objectRenderer.material.color = highlightColor; // Changes the color of the objects material
    }
    void OnMouseExit() // Called when users mouse exits the game objects collider
    {
        objectRenderer.material.color = originalColor; // Return game object to original color
    }
}