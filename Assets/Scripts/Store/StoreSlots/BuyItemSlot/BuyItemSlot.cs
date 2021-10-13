using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItemSlot : MonoBehaviour
{
    //Serialized Fields
    [Header("Item configuration")]
    [SerializeField]
    private GameObject item = null;
    [Header("Location configuration")]
    [SerializeField]
    private Transform locationToDropItem = null;
    [Header("Parent configuration")]
    [SerializeField]
    private GameObject parent = null;
    [Header("Price configuration")]
    [SerializeField]
    private int price = 100;

    //Non serialized field
    private GameObject gameController = null;

    public void buyItem()
    {
        this.gameController = GameObject.FindWithTag("GameController");

        if (this.gameController.GetComponent<GameController>().getPlayerCoins() >= this.price)
        {
            if (this.gameController.transform.GetChild(1).GetComponent<Inventory>().isAnySlotInInventoryEmpty())
            {
                this.gameController.GetComponent<GameController>().setPlayerCoins(-this.price);
                GameObject newItem = Instantiate(this.item, new Vector3(this.locationToDropItem.position.x, this.locationToDropItem.position.y, 0), Quaternion.identity);
                newItem.SetActive(false);
                newItem.transform.SetParent(this.parent.transform);

                this.gameController.transform.GetChild(1).GetComponent<Inventory>().addItem(newItem);
            }
        }
    }

    public GameObject getItem()
    {
        return this.item;
    }
}
