using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorial;
    void Start()
    {
        if(PlayerPrefs.HasKey("tutorial"))
        {
            if(PlayerPrefs.GetInt("tutorial")==1)
            {
                Destroy(tutorial);
                Destroy(gameObject);
            }
            
        }
        else
        {
            tutorial.SetActive(false);
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tutorial.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        PlayerPrefs.SetInt("tutorial", 1);
        Destroy(tutorial);
        Destroy(gameObject);
    }
}
