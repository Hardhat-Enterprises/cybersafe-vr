using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    public Canvas canvasToDeactivate;
    public Canvas canvasToActivate;

    private void Start()
    {
        // Ensure one canvas is active and the other is inactive at the start
        canvasToDeactivate.gameObject.SetActive(true);
        canvasToActivate.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        // Deactivate the current canvas
        canvasToDeactivate.gameObject.SetActive(false);

        // Activate the other canvas
        canvasToActivate.gameObject.SetActive(true);
    }
}
