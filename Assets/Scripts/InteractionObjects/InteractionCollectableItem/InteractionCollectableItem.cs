using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCollectableItem : Interaction
{
    private enum ItemType
    {
        Consumable,
        Amulet,
        Ring,
        Helmet,
        ChestPlate,
        Sword,
        Boots
    };

    //Serialized fields
    [Header("Item type configuration")]
    [SerializeField]
    private ItemType itemType;

    //Non serialized fields
    private GameObject gameController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
    }

    public override void interaction()
    {
        colectItem();
    }

    private void colectItem()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.itemType == ItemType.Amulet)
            {
                this.gameController.transform.GetChild(1).GetComponent<Inventory>().addAmulet(this.gameObject);
            }
            else
            {
                this.gameController.transform.GetChild(1).GetComponent<Inventory>().addItem(this.gameObject);
            }
        }
    }

    
}
