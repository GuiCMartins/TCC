using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Non serialized fields
    [Header("Items on inventory configuration")]
    [SerializeField]
    private GameObject[] itemsInInventory = null;

    //Serialized Fields
    [Header("Slot configuration")]
    [SerializeField]
    private GameObject slots = null;

    public void addItem(GameObject item)
    {
        foreach(Transform slot in this.slots.transform)
        {
            if (slot.GetComponent<Slot>().isSlotEmpty())
            {
                this.itemsInInventory[slot.GetComponent<Slot>().getId()] = item;
                slot.GetComponent<Slot>().addItem(item.GetComponent<SpriteRenderer>().sprite);
                break;
            }
        }
    }
    
    public void removeItem(int id)
    {
        this.itemsInInventory[id] = null;
    }
}
