using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //Serialized fields
    [Header("Inventory configuration")]
    [SerializeField]
    private Inventory inventory = null;
    [Header("Id configuration")]
    [SerializeField]
    private int id = 0;

    //Non serialized fields
    private Image icon = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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

    public int getId()
    {
        return this.id;
    }
}
