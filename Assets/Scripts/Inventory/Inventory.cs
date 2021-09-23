using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Non serialized fields
    [SerializeField]
    private GameObject[] itemsInInventory = new GameObject[12];
    [SerializeField]
    private GameObject[] AmuletsInInventory = new GameObject[8];

    //Serialized Fields
    [Header("Item slots configuration")]
    [SerializeField]
    private GameObject itemSlots = null;
    [Header("Amulet slots configuration")]
    [SerializeField]
    private GameObject amuletSlots = null;

    public void addItem(GameObject item)
    {
        foreach(Transform slot in this.itemSlots.transform)
        {
            if (slot.GetComponent<Slot>().isSlotEmpty())
            {
                this.itemsInInventory[slot.GetComponent<Slot>().getId()] = item;
                slot.GetComponent<Slot>().addItem(item.GetComponent<SpriteRenderer>().sprite);
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
                this.AmuletsInInventory[slot.GetComponent<Slot>().getId()] = item;
                slot.GetComponent<Slot>().addItem(item.GetComponent<SpriteRenderer>().sprite);
                item.SetActive(false);
                break;
            }
        }
    }
    
    public void removeItem(int id)
    {
        this.itemsInInventory[id] = null;
    }
}
