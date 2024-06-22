using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject inv;
    public GameObject dropSound;
    private AudioSource audioSource;
    void Start()
    {
         audioSource = dropSound.GetComponent<AudioSource>();
    }

    public void RemoveItem()
    {
        InvManager InvManager= GameObject.FindObjectOfType<InvManager>();
       

        List<Item> itemsInInv = new List<Item>();
        foreach(Item it in InvManager.Items)
        {
            itemsInInv.Add(it);
        }

        foreach(Item it in itemsInInv)
        {
            
            if(it.itemName==PlayerPrefs.GetString("ClickedItem"))
            {
                audioSource.Play();
                InvManager.Items.Remove(it);
                inv.SetActive(false);
            }
        }
        
    }
    
}