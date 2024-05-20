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

