using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDaughtersRoom : MonoBehaviour
{
    public Camera mainCamera;
    public Camera HaikuCamera;
    public Camera DaughterCamera;

    void Start()
    {
        if (mainCamera == null)
        {
            Debug.LogError("Main camera reference is not set!");
        }
        if (HaikuCamera == null)
        {
            Debug.LogError("Zoom camera reference is not set!");
        }

        if (HaikuCamera != null)
        {
            HaikuCamera.enabled = false;
        }
        if (DaughterCamera != null) 
        {
            DaughterCamera.enabled = false;
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
                if (hit.transform.CompareTag("Haiku"))
                {
                    Debug.Log("Clicked on the Haiku!");
                    if (mainCamera != null && HaikuCamera != null && DaughterCamera != null)
                    {
                        mainCamera.enabled = false;
                        DaughterCamera.enabled = false;
                        HaikuCamera.enabled = true;
                    }
                }
                else if (hit.transform.CompareTag("Daughter"))
                {
                    Debug.Log("Clicked on the Daughter!");
                    if (mainCamera != null && HaikuCamera != null && DaughterCamera != null)
                    {
                        mainCamera.enabled = false;
                        HaikuCamera.enabled = false;
                        DaughterCamera.enabled = true;
                    }
                }
                else
                {
                    Debug.Log("Clicked outside!");
                    if (mainCamera != null && HaikuCamera != null && DaughterCamera != null || HaikuCamera.enabled || DaughterCamera.enabled)
                    {
                        HaikuCamera.enabled = false;
                        DaughterCamera.enabled = false;
                        mainCamera.enabled = true;
                    }
                }
            }
            else
            {
                Debug.Log("Clicked outside any object!");
                if (mainCamera != null && HaikuCamera != null && DaughterCamera != null || HaikuCamera.enabled || DaughterCamera.enabled)
                {
                    HaikuCamera.enabled = false;
                    mainCamera.enabled = true;
                    DaughterCamera.enabled = false;
                }
            }
        }
    }
}
