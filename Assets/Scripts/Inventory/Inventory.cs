using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Non serialized fields
    [SerializeField]
    private GameObject[] itemsInInventory = new GameObject[9];
    [SerializeField]
    private GameObject[] amuletsInInventory = new GameObject[8];
    [SerializeField]
    private GameObject[] equipmentsInInventory = new GameObject[6];

    //Serialized Fields
    [Header("Item slots configuration")]
    [SerializeField]
    private GameObject itemSlots = null;
    [Header("Amulet slots configuration")]
    [SerializeField]
    private GameObject amuletSlots = null;
    [Header("Equipments slots configuration")]
    [SerializeField]
    private GameObject equipmentSlots = null;

    public void addItem(GameObject item)
    {
        foreach(Transform slot in this.itemSlots.transform)
        {
            if (slot.GetComponent<Slot>().isSlotEmpty())
            {
                this.itemsInInventory[slot.GetComponent<Slot>().getId()] = item;
                slot.GetComponent<Slot>().addItem(item);
                item.SetActive(false);
                break;
            }
        }
    }

    public void addAmulet(GameObject item)
    {
        foreach (Transform slot in this.amuletSlots.transform)
        {
            if (slot.GetComponent<Slot>().isSlotEmpty())
            {
                this.amuletsInInventory[slot.GetComponent<Slot>().getId()] = item;
                slot.GetComponent<Slot>().addItem(item);
                item.SetActive(false);
                break;
            }
        }
    }

    public void addEquipments(GameObject item)
    { 
        foreach (int id in item.GetComponent<UseItemBase>().getIdSlot()){
            if (this.equipmentsInInventory[id] == null)
            {
                 removeItemOfInventoryAddInEquipment(item);
                 this.equipmentsInInventory[id] = item;
                 this.equipmentSlots.transform.GetChild(id).GetComponent<Slot>().addItem(item);
                 item.GetComponent<UseItemBase>().useItem();
                 break;
            }
        }
    }

    public void useItem(GameObject item)
    {
        item.GetComponent<UseItemBase>().useItem();
    }

    public void unUseItem(GameObject item)
    {
        item.GetComponent<UseItemBase>().unUseItem();
    }

    public void removeItemInInventory(int id)
    {
        this.itemsInInventory[id] = null;
    }

    public void removeEquipmentInInventory(int id)
    {
        this.equipmentsInInventory[id] = null;
    }

    public bool isAnySlotInInventoryEmpty()
    {
        foreach (Transform slot in this.itemSlots.transform)
        {
            if (slot.GetComponent<Slot>().isSlotEmpty())
            {
                return true;
            }
        }
        return false;
    }

    private void removeItemOfInventoryAddInEquipment(GameObject item)
    {
        foreach (Transform slot in this.itemSlots.transform)
        {
            if (this.itemsInInventory[slot.GetComponent<Slot>().getId()] == item)
            {
                slot.GetComponent<Slot>().removeItemInInventory();
                break;
            }
        }
    }
}
