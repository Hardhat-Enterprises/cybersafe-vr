using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    public float delay = 3f; // Time before the object disappears/is destroyed.

    void Start()
    {
        Destroy(gameObject, delay); // This calls the Unity destroy function, it acts on the gameObject, while delay specifies the time previously noted.
    }
}
