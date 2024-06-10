using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScriptForAttic : MonoBehaviour
{
    public Camera firstfloorCamera;
    public Camera parentsRoomCamera;
    public Camera atticCamera;
    public Camera daisyRoomCamera;
    public Camera bathroomCamera;
    public Camera andyRoomCamera;

    public Camera zoomCamera;
    private Camera mainCamera;

    void Start()
    {/*
        Camera[] cameras = { firstfloorCamera, parentsRoomCamera, atticCamera, daisyRoomCamera, bathroomCamera, andyRoomCamera };

        foreach (Camera cam in cameras)
        {
            if (cam != null && cam.enabled)
            {
                Debug.Log("Kameraaaaa" + cam);
                mainCamera = cam;
                break;
            }
        } */
        int previousScene = PlayerPrefs.GetInt("previousScene");

        switch (previousScene)
        {
            case 3: // Index of the first floor scene
                mainCamera = firstfloorCamera;
                break;
            case 8: // Index of the parents room scene
                mainCamera = parentsRoomCamera;
                break;
            case 7: // Index of the daisy room scene
                mainCamera = daisyRoomCamera;
                break;
            case 9: // Index of the bathroom scene
                mainCamera = bathroomCamera;
                break;
            case 6: // Index of the andy room scene
                mainCamera = andyRoomCamera;
                break;
            default:
                Debug.LogWarning("Previous scene index not recognized. Using default camera.");
                // Assign a default camera if the index is not recognized
                mainCamera = firstfloorCamera;
                break;
        }
        zoomCamera.enabled = false;
      //  mainCamera = Camera.current.GetComponent<Camera>();
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
                if (hit.transform.CompareTag("NotKeypad"))
                {
                    Debug.Log("Clicked on the notKeypad!");

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
