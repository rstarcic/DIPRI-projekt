using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScriptForPhone : MonoBehaviour
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
                if (hit.transform.CompareTag("Phone"))
                {
                    Debug.Log("Clicked on the phone!");
                    if (mainCamera != null && zoomCamera != null)
                    {
                        mainCamera.enabled = false;
                        zoomCamera.enabled = true;
                    }
                }
                else
                {
                    Debug.Log("Clicked outside the phone!");
                    if (mainCamera != null && zoomCamera != null && zoomCamera.enabled)
                    {
                        zoomCamera.enabled = false;
                        mainCamera.enabled = true;
                    }
                }
            }
            else
            {
                Debug.Log("Clicked outside any object!");
                if (mainCamera != null && zoomCamera != null && zoomCamera.enabled)
                {
                    zoomCamera.enabled = false;
                    mainCamera.enabled = true;
                }
            }
        }
    }
}
