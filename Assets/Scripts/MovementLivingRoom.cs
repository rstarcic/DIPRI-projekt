using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementLivingRoom : MonoBehaviour
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
        if (Input.GetMouseButtonDown(1)) // Left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Drawer") || hit.collider.CompareTag("Drawer1"))
            {
                drawerBehaviour.ToggleDrawer();
            }
            else
            {
                agent.SetDestination(hit.point);

            }
        }

        if (Input.GetMouseButton(0)) // Right mouse button press
        {
            PlayerCamera.transform.RotateAround(agent.nextPosition,
                                                Vector3.up,
                                                -Input.GetAxis("Mouse X") * 10);
        }
    }
}