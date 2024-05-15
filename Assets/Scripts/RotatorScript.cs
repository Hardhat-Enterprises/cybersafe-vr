using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour // Defining the public class, inheriting from MonoBehavior - all scripts that control game objects in Unity must inherit from MonoBehavior
{
    public Vector3 rotationSpeed; // Declaring public variable named rotationSpeed, of the Vector3 type. Vector3 stores the rotation speed of the object around each axis (X Y Z)

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime); // Rotates the object by the specified amount of time. 
    }
}
