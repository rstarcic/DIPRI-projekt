using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = item.soundItem;
    }

    void pickup()
    {
       InvManager InvManager= GameObject.FindObjectOfType<InvManager>();
       if(InvManager.Items.Count<4)
        {
            InvManager.Add(item);
            Debug.Log("Audio should start." + item.soundItem);
            audioSource.Play();
            // Destroy(gameObject);
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }
        else {InvManager.invLimit();}
    }

    private void OnMouseDown()
    {
        pickup();
    }
    
}
