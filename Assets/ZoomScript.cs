using UnityEngine;

public class ZoomScript : MonoBehaviour
{
    public Camera mainCamera;
    public Camera zoomCamera;

    void Start()
    {
        if (mainCamera == null)
        {
            Debug.LogError("Main camera reference is not set!");
        }
        if (zoomCamera == null)
        {
            Debug.LogError("Zoom camera reference is not set!");
        }

        if (zoomCamera != null)
        {
            zoomCamera.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Keypad"))
                {
                    Debug.Log("Clicked on the keypad!");

                    mainCamera.enabled = false;
                    if (zoomCamera != null)
                    {
                        zoomCamera.enabled = true;
                        Debug.Log("Zoom camera enabled!");
                    }
                    else
                    {                        
                        Debug.LogError("Zoom camera reference is not set!");
                    }
                }
                else
                {
                    Debug.Log("Clicked outside keyboard!");
                }
            }
        }
    }
}
