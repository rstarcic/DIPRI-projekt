using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void pickup()
    {
        if(InvManager.Instance.Items.Count<4)
        {
            InvManager.Instance.Add(item);
            Destroy(gameObject);
        }
        else {Debug.Log("previse");}
    }

    private void OnMouseDown()
    {
        pickup();
    }
    
}
