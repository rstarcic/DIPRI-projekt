using UnityEngine;

[CreateAssetMenu(fileName ="New item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public Sprite icon;
}
