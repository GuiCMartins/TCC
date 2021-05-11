using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCollectableItem : Interaction
{
    //Serialized  fields
    [Header("Item configuration")]
    [SerializeField]
    private GameObject item = null;
    [Header("Inventory configuration")]
    [SerializeField]
    private Inventory inventory = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    public override void interaction()
    {
        colectItem();
    }

    private void colectItem()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.inventory.addItem(this.item);
            Destroy(this.gameObject);
        }
    }
}
