using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void pickup()
    {
       InvManager InvManager= GameObject.FindObjectOfType<InvManager>();
       if(InvManager.Items.Count<4)
        {
            InvManager.Add(item);
            Destroy(gameObject);
        }
        else {InvManager.invLimit();}
    }

    private void OnMouseDown()
    {
        pickup();
    }
    
}
