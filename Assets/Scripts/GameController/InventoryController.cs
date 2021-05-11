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
        openCloseInventory();
    }

    private void openCloseInventory()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            bool isOpen = !this.inventory.activeSelf;
            this.inventory.SetActive(isOpen);

            if (isOpen)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
