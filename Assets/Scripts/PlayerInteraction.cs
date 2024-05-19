using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Camera PlayerCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Drawer drawer = hit.transform.GetComponent<Drawer>();
                if (drawer != null)
                {
                    drawer.Toggle(); 
                }
            }
        }
    }
}
