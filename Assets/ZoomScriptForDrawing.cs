using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScriptForDrawing : MonoBehaviour
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
                if (hit.transform.CompareTag("Drawing"))
                {
                    Debug.Log("Clicked on the drawing!");
                    if (mainCamera != null && zoomCamera != null)
                    {
                        mainCamera.enabled = false;
                        zoomCamera.enabled = true;
                    }
                }
                else
                {
                    Debug.Log("Clicked outside the drawing!");
                    if (mainCamera != null && zoomCamera != null)
                    {
                        zoomCamera.enabled = false;
                        mainCamera.enabled = true;
                    }
                }
            }
    }
    }
}

