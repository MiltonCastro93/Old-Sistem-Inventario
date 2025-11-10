using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private static InventorySystem instance;
    public static InventorySystem Instance => instance;

    public delegate void OnInventoryChangeEvent();
    public event OnInventoryChangeEvent OnInventoryChageEventCallback;

    public Dictionary<InventoryItemData, InventoryItem> inventoryDictionary = new();
    public List<InventoryItem> inventory = new();

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            DestroyImmediate(gameObject);
        }

    }

    public void Add(InventoryItemData itemData) {
        if (inventoryDictionary.TryGetValue(itemData, out InventoryItem item)){
            item.AddStack();
        } else {
            //En el Caso que no exista en tu inventario
            InventoryItem newItem = new InventoryItem(itemData);

            inventory.Add(newItem);
            inventoryDictionary.Add(itemData,newItem);
        }
        OnInventoryChageEventCallback.Invoke();//hacemos una actualizacion de pantalla
    }

    public void Remove(InventoryItemData itemData) {
        if (inventoryDictionary.TryGetValue(itemData, out InventoryItem item)) {
            item.RemoveStack();
        } 
        if(item.stackQty == 0){ //En el Caso que no exista mas, lo saco
            InventoryItem newItem = new InventoryItem(itemData);

            inventory.Remove(newItem);
            inventoryDictionary.Remove(itemData);
        }
        OnInventoryChageEventCallback.Invoke();//hacemos una actualizacion de pantalla
    }

}
