using UnityEngine;

public class ZoomScript : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject zoomCamera;
    public GameObject zoomCamera1;

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
        if (zoomCamera1 == null)
        {
            Debug.LogError("Zoom camera1 reference is not set!");
        }

        if (zoomCamera != null)
        {
            zoomCamera.SetActive(false);
        }
        if (zoomCamera1 != null)
        {
            zoomCamera1.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            Ray ray2 = zoomCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            Ray ray3 = zoomCamera1.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Keypad"))
                {
                    Debug.Log("Clicked on the keypad!");
                    if (zoomCamera != null)
                    {
                        zoomCamera.SetActive(true);
                        Debug.Log("Zoom camera enabled!");
                    }
                }
            }
            if (Physics.Raycast(ray2, out hit))
            {
                if (hit.transform.CompareTag("Safe"))
                {
                    Debug.Log("Clicked on the safe!");

                    zoomCamera.SetActive(false);
                    if (mainCamera != null)
                    {
                        mainCamera.SetActive(true);
                        Debug.Log("Main camera active!");
                    }
                }

            }
            if (Physics.Raycast(ray3, out hit))
            {
                if (hit.transform.CompareTag("NotSafe"))
                {
                    Debug.Log("Not clicked on the safe!");
 
                    zoomCamera1.SetActive(false);
                    if (mainCamera != null)
                    {
                        mainCamera.SetActive(true);
                        Debug.Log("Main camera enabledddd!");
                    }
                }
               
            }
        }
    }
}
