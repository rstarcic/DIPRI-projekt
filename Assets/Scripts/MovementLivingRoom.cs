using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementLivingRoom : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera PlayerCamera;
    public DrawerAnimationBehaviour drawerBehaviour;
    public OpenFridgeDoor fridgeBehaviour;
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
            else if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Fridge"))
            {
                fridgeBehaviour.ToggleDoor();
            }
         /*   else
            {
                agent.SetDestination(hit.point);

            }
         */
        }
        /*
        if (Input.GetMouseButton(1)) // Right mouse button press
        {
            PlayerCamera.transform.RotateAround(agent.nextPosition,
                                                Vector3.up,
                                                -Input.GetAxis("Mouse X") * 10);
        }
        */
    }
}