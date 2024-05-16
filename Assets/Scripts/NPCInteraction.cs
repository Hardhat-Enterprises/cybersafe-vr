using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public GameObject speechBubblePrefab;
    public Transform character; // Reference to the character (e.g., FirstPersonController)

    private GameObject currentSpeechBubble;

    private void OnMouseDown()
    {
        ShowSpeechBubble();
    }

    private void ShowSpeechBubble()
    {
        // If a speech bubble is already active, destroy it before showing a new one
        if (currentSpeechBubble != null)
        {
            Destroy(currentSpeechBubble);
        }

         // Calculate the position for the speech bubble
        Vector3 bubblePosition = transform.position + Vector3.up * 1 - Vector3.right * 1f; // Adjust the x value here

        // Instantiate the speech bubble prefab
        currentSpeechBubble = Instantiate(speechBubblePrefab, bubblePosition, Quaternion.identity);

        // Calculate the direction from the speech bubble to the character
        Vector3 directionToCharacter = character.position - currentSpeechBubble.transform.position;

        // Rotate the speech bubble to face the character
        currentSpeechBubble.transform.rotation = Quaternion.LookRotation(directionToCharacter.normalized, Vector3.up);
        
        // Parent the speech bubble to the NPC
        currentSpeechBubble.transform.parent = transform;
    }

    public void MoveSpeechBubble(Vector3 newPosition)
    {
        if (currentSpeechBubble != null)
        {
            currentSpeechBubble.transform.position = newPosition;
        }
    }
}
