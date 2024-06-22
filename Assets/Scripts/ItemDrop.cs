using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject inv;
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
                InvManager.Items.Remove(it);
                inv.SetActive(false);
            }
        }
        
    }
    
}