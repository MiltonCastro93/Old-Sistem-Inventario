using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpItem : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Collectable")) {
            ItemObject itemObject;
            itemObject = other.GetComponent<ItemObject>();
            itemObject.PickUp();
        }
    }

}
