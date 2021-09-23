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

    //Non serialized fields
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

    public void addItem(Sprite spriteItem)
    {
        this.icon = this.transform.GetChild(0).GetComponent<Image>();
        this.icon.sprite = spriteItem;
    }

    public void removeItem()
    {
        this.icon.sprite = null;
        this.icon = null;
        this.inventory.removeItem(this.id);
    }

    public void useItem()
    {

    }

    public int getId()
    {
        return this.id;
    }
}
