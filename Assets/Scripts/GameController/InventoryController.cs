using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    //Serialized Fields
    [Header("Inventory configuration")]
    [SerializeField]
    private GameObject inventory = null;

    // Start is called before the first frame update
    void Start()
    {
        this.inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        openInventory();
    }

    private void openInventory()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.inventory.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
