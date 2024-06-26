using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManager : MonoBehaviour
{
    public static InvManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform contents;
    public GameObject InventoryItem;

    
    public void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        GameObject[] itemsOnScene= GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in itemsOnScene)
        {
            ItemController ctrl = item.GetComponent<ItemController>();
            int a = ctrl.item.id;
            foreach(Item it in Items)
            {
                if(it.id==a)
                {
                    //    Destroy(item);
                    item.GetComponent<Renderer>().enabled = false;
                }
                
            }
        }
    }

     public void Add(Item item)
    {
        Items.Add(item);
    }


    public void ListItems()
    {
        foreach(Transform item in contents)
        {
            Destroy(item.gameObject);
        }
        foreach(var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, contents);
            var itemName = obj.transform.Find("Icon_1/ItemName").GetComponent<TMPro.TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("Icon_1/ItemmIcon").GetComponent<Image>();
            itemName.text = item.itemName;
            itemIcon.sprite=item.icon;
            
        }
    }
    public bool HasItem(int id)
    {
        return Items.Exists(item => item.id == id);
    }

    public void Remove(int id)
    {
        Item itemToRemove = Items.Find(item => item.id == id);
        if (itemToRemove != null)
        {
            Items.Remove(itemToRemove);
        }
    }
    public void invLimit()
    {
        displayMessage();
        Invoke("hideMessage", 2.0f);
    }

    public void displayMessage()
    {
        GameObject limitText = GameObject.FindGameObjectWithTag("invLimit");
        limitText.GetComponent<Canvas>().enabled=true; 
    }
    public void hideMessage()
    {
        GameObject limitText = GameObject.FindGameObjectWithTag("invLimit");
        limitText.GetComponent<Canvas>().enabled=false; 
    }

    

}

