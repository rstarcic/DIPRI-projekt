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
                    Destroy(item);
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
    
}

