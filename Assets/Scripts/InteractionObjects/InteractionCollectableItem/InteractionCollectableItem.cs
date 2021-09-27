using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCollectableItem : Interaction
{
    //Serialized fields
    [Header("Item type configuration")]
    [SerializeField]
    private bool isAmulet;

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
            if (this.isAmulet)
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
