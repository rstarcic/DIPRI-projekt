using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EnterTrigger : MonoBehaviour
{
    public GameObject button;
    
    void Start()
    {
        button.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            button.gameObject.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        button.gameObject.SetActive(false);
    }
}
