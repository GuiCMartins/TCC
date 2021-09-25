﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //Serialized fields
    [Header("Id configuration")]
    [SerializeField]
    private int id = 0;

    //Non serialized fields
    private GameObject item = null;
    private Image icon = null;
    private Inventory inventory = null;

    void Start()
    {
        this.inventory = GameObject.FindWithTag("GameController").transform.GetChild(1).GetComponent<Inventory>();
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

    public void removeItemInInventory()
    {
        freeSprite();
        this.inventory.removeItemInInventory(this.id);
        this.item.SetActive(true);
    }

    public void removeEquipmentInInventory()
    {
        if (this.inventory.isAnySlotInInventoryEmpty())
        {
            freeSprite();
            this.inventory.addItem(this.item);
            this.inventory.removeEquipmentInInventory(this.id);
        }
    }

    public void useItem()
    {
        this.inventory.addEquipments(this.item);
    }

    public int getId()
    {
        return this.id;
    }

    private void freeSprite()
    {
        this.icon.sprite = null;
        this.icon = null;
    }
}
