using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WallTriggerScript : MonoBehaviour
{
    public GameObject wall; 
    public NavMeshObstacle wallNavMeshObstacle; 

    void Start()
    {
        if (wallNavMeshObstacle == null && wall != null)
            wallNavMeshObstacle = wall.GetComponent<NavMeshObstacle>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (wallNavMeshObstacle != null)
            {
                wallNavMeshObstacle.carving = false; 
                wallNavMeshObstacle.enabled = false; 
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (wallNavMeshObstacle != null)
            {
                wallNavMeshObstacle.carving = true;
                wallNavMeshObstacle.enabled = true; 
            }
        }
    }
}
