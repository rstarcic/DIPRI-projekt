using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class EnterTrigger : MonoBehaviour
{
    public GameObject button;
    
    void Start()
    {
        Collider bttn = button.GetComponent<Collider>();
        //button.gameObject.SetActive(false);
        bttn.enabled=false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Collider bttn = button.GetComponent<Collider>();
            bttn.enabled=true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        Collider bttn = button.GetComponent<Collider>();
        bttn.enabled=false;
    }
}
