using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //Serialized fields
    [Header("Id configuration")]
    [SerializeField]
    private int id = 0;
    [Header("Sprite default configuration")]
    [SerializeField]
    private Sprite spriteDefault = null;

    //Non serialized fields
    private GameObject item = null;
    private Image icon = null;
    private Inventory inventory = null;
    private GameObject player = null;

    void Start()
    {
        this.inventory = GameObject.FindWithTag("GameController").transform.GetChild(1).GetComponent<Inventory>();
        this.player = GameObject.FindWithTag("Player");
    }

    public bool isSlotEmpty()
    {
        if(icon == null)
        {
            return true;
        }

        return false;
    }

    public void addItem(GameObject item)
    {
        this.item = item;
        this.icon = this.transform.GetChild(0).GetComponent<Image>();
        this.icon.sprite = item.GetComponent<SpriteRenderer>().sprite;
    }

    public void dropItemFromInventory()
    {
        dropItem();
        removeItemInInventory();
    }

    public void removeItemInInventory()
    {
        this.inventory.removeItemInInventory(this.id);
        removeItemSlot();
    }

    public void removeEquipmentInInventory()
    {
        if (this.inventory.isAnySlotInInventoryEmpty())
        {
            this.inventory.addItem(this.item);
            this.inventory.removeEquipmentInInventory(this.id);
            this.inventory.unUseItem(this.item);
            removeItemSlot();
        }
    }

    public void useItem()
    {
        if (this.item != null)
        {
            if (!this.item.GetComponent<UseItemBase>().isConsumable())
            {
                this.inventory.addEquipments(this.item);
            }
            else{
                this.inventory.useItem(this.item);
                this.inventory.unUseItem(this.item);
            }
        }
    }

    public int getId()
    {
        return this.id;
    }

    private void removeItemSlot()
    {
        this.icon.sprite = this.spriteDefault;
        this.icon = null;
        this.item = null;
    }

    private void dropItem()
    {
        this.item.transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y, this.item.transform.position.z);
        this.item.SetActive(true);
    }
}
