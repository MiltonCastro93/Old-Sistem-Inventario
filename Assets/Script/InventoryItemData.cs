using UnityEngine;

[CreateAssetMenu(fileName = "Inventory Data",menuName = "Inventory System/Create new Item Data")]
public class InventoryItemData : ScriptableObject
{
    [Tooltip("Unico Item ID.")]
    public string itemID;

    [Tooltip("Item name, aparecera en mi inventario.")]
    public string itemName;

    [Tooltip("Item 2D Sprite, aparecera en mi inventario.")]
    public Sprite itemIcon;

    [Tooltip("Item GameObject.")]
    public GameObject itemPrefab;

    [TextArea(17, 1000)]
    public string comment = "Comentarios del Item";

}
//Los datos necesarios para el item del juego