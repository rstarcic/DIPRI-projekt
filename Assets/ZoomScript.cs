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
            Ray ray2 = zoomCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Keypad"))
                {
                    Debug.Log("Clicked on the keypad!");
                    if (zoomCamera != null)
                    {
                        zoomCamera.enabled = true;
                        Debug.Log("Zoom camera enabled!");
                    }
                }
            }
            if (Physics.Raycast(ray2, out hit))
            {
                if (hit.transform.CompareTag("Safe"))
                {
                    Debug.Log("Clicked on the safe!");

                    zoomCamera.enabled = false;
                    if (mainCamera != null)
                    {
                        mainCamera.enabled = true;
                        Debug.Log("Main camera enabled!");
                    }
                }

            }
        }
    }
}
