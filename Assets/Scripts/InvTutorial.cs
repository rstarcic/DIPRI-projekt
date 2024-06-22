using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvTitorial : MonoBehaviour
{
    public GameObject tutorial;
    void Start()
    {
        if(PlayerPrefs.HasKey("invTutorial"))
        {
            if(PlayerPrefs.GetInt("invTutorial")==1)
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
        PlayerPrefs.SetInt("invTutorial", 1);
        Destroy(tutorial);
        Destroy(gameObject);
    }
}
