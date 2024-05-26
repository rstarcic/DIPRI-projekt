using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    
    void Start()
    {
        
        textMesh.GetComponent<TextMeshProUGUI>();
        textMesh.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            textMesh.gameObject.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        textMesh.gameObject.SetActive(false);
    }
}
