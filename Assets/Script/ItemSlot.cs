using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ItemSlot : MonoBehaviour, IPointerClickHandler {
    [SerializeField] private Sprite _itemIcon;
    [SerializeField] private TextMeshProUGUI _itemName;
    [SerializeField] private GameObject _stackQtyBgn;
    [SerializeField] private TextMeshProUGUI _stackQty;

    InventoryItem _item;
    Button _button;

    private void Awake() {
        _button = GetComponent<Button>();
    }

    public void Set(InventoryItem item) {
        _item = item;
        _itemName.text = item.data.itemName;
        _button.image.sprite = item.data.itemIcon;

        if (item.stackQty > 1) {
            _stackQtyBgn.SetActive(true);
            _stackQty.enabled = true;
            _stackQty.text = item.stackQty.ToString();
        } else {
            _stackQtyBgn.SetActive(false);
            _stackQty.enabled = false;
        }

    }

    public void OnPointerClick(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Left) {
            Debug.Log("Left Clic");
            ItemActionsManager.Instance.UseSelectedItem(_item);
        }
        else if (eventData.button == PointerEventData.InputButton.Right) {
            Debug.Log("Right Clic");
            ItemActionsManager.Instance.DropSelectedItem(_item);
        }
    }
}
