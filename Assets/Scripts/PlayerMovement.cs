using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementScript : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera cam1;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        if(Input.GetMouseButton(0))
        {
         cam1.transform.RotateAround(agent.nextPosition, 
                                         Vector3.up,
                                         -Input.GetAxis("Mouse X")*10);

         
        } 
    }
}
