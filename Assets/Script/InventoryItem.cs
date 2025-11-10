

[System.Serializable]
public class InventoryItem {
    public InventoryItemData data;
    public int stackQty; //<Sumar cantidad del mismo item

    public InventoryItem(InventoryItemData itemData) {
        data = itemData;
        AddStack();
    }//Constructor

    public void AddStack() {
        stackQty++;
    }
    public void RemoveStack() {
        stackQty--;
    }

}
//Ordenara y consumira los Items