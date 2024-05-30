
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera PlayerCamera;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Right mouse button click
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point); 

            }
        }

        if (Input.GetMouseButton(0)) // Left mouse button press
        {
            PlayerCamera.transform.RotateAround(agent.nextPosition,
                                                Vector3.up,
                                                -Input.GetAxis("Mouse X") * 10);
        }
    }
}