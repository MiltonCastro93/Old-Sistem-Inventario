using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour {

    [SerializeField] private bool _isInteractuable;
    [SerializeField] private bool _IsCollectable;

    public bool IsCollectable { get { return _isInteractuable; } set { _isInteractuable = value; } }
    public bool IsInteractuable { get; set; }

    public InventoryItemData itemData;

    public void PickUp() {
        InventorySystem.Instance.Add(itemData);
        Destroy(gameObject);
    }

}
