using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScriptForPhone : MonoBehaviour
{
    public Camera mainCamera;
    public Camera zoomCamera;
    public Camera WifeZoomCamera;

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
        if (WifeZoomCamera != null) 
        {
            WifeZoomCamera.enabled = false;
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
                if (hit.transform.CompareTag("Phone"))
                {
                    Debug.Log("Clicked on the phone!");
                    if (mainCamera != null && zoomCamera != null && WifeZoomCamera != null)
                    {
                        mainCamera.enabled = false;
                        WifeZoomCamera.enabled = false;
                        zoomCamera.enabled = true;
                    }
                }
                else if (hit.transform.CompareTag("Wife"))
                {
                    Debug.Log("Clicked on the wife!");
                    if (mainCamera != null && zoomCamera != null && WifeZoomCamera != null)
                    {
                        mainCamera.enabled = false;
                        zoomCamera.enabled = false;
                        WifeZoomCamera.enabled = true;
                    }
                }
                else
                {
                    Debug.Log("Clicked outside the phone!");
                    if (mainCamera != null && zoomCamera != null && zoomCamera.enabled && WifeZoomCamera != null && WifeZoomCamera.enabled)
                    {
                        zoomCamera.enabled = false;
                        WifeZoomCamera.enabled = false;
                        mainCamera.enabled = true;
                    }
                }
            }
            else
            {
                Debug.Log("Clicked outside any object!");
                if (mainCamera != null && zoomCamera != null && WifeZoomCamera != null || zoomCamera.enabled || WifeZoomCamera.enabled)
                {
                    zoomCamera.enabled = false;
                    mainCamera.enabled = true;
                    WifeZoomCamera.enabled = false;
                }
            }
        }
    }
}
