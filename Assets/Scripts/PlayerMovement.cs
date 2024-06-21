using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementScript : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera cam1;
    Animator playerAnim;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerAnim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
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
                print("Walk");
                playerAnim.SetBool("Walk", true);
                if(!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
    
        }
       if (!agent.pathPending)
{
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                   playerAnim.SetBool("Walk", false);
                    audioSource.Stop();
                }
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
