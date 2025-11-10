using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActionsManager : MonoBehaviour
{
    public static ItemActionsManager Instance { get; set; }

    private InventoryItem _selectedItem;

    private void Awake() {
        if(Instance != null && Instance != this) {
            Destroy(Instance);
        } else {
            Instance = this;
        }

    }

    public void UseSelectedItem(InventoryItem item) {
        if (_selectedItem == null) return;

        Debug.Log($"Usando {_selectedItem.data.name}.");
        //Aqui puedes añadir la logica especifica del consumo.
        //por ejemplo, buscar una animacion del jugador y realizar la accion de.
        // Usar/ Comer/ Equipar.

        //Elimina una unidad del Item del inventario
        InventorySystem.Instance.Remove(_selectedItem.data);

        //Deselecciona el item despues de usarlo.
        //DeselectItem();
    }

    public void DropSelectedItem(InventoryItem item) {
        if(_selectedItem == null) return;

        Debug.Log($"Soltado {_selectedItem.data.itemName}.");

        //Instancia el prefab del item en una posicion frente al jugador(ejemplo).
        //Ajusta la posicion segun las necesidades de tu juego.

        Vector3 dropPosition = Camera.main.transform.position + Camera.main.transform.forward * 2f;

        Instantiate(_selectedItem.data.itemPrefab,dropPosition, Quaternion.identity);

        //Elimina una unidad del item del inventario.
        InventorySystem.Instance.Remove(_selectedItem.data);

        //Deselecciona el item despues de usarlo.
        //DeselectItem();
    }

}
