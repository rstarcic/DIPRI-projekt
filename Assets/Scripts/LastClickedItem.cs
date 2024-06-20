using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastClickedItem : MonoBehaviour
{
    public void ClickedItem()
    {
        string clickedItem=gameObject.transform.Find("Icon_1/ItemName").GetComponent<TMPro.TextMeshProUGUI>().text;
        PlayerPrefs.SetString("ClickedItem", clickedItem);
    }
}
