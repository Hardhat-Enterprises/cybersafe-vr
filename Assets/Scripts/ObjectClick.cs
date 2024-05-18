using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public SceneManagerScript sceneManagerScript; // Reference to the SceneManagerScript
    public string sceneName; // Name of the scene to load

    // This method will be called when the object is clicked
    private void OnMouseDown()
    {
        // Load the specified scene
        sceneManagerScript.LoadScene(sceneName);
    }
}
