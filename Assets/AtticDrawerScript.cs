using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AtticDrawerScript : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera PlayerCamera;
    public DrawerAnimationBehaviour drawerBehaviour;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Drawer"))
            {
                drawerBehaviour.ToggleDrawer();
            }
        }
    }
}
