using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSlotController : MonoBehaviour
{
    //Serialized Fields
    [Header("Slot configuration")]
    [SerializeField]
    private GameObject slot = null;

    //Non serialized fields
    private GameObject storeController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.storeController = GameObject.FindWithTag("GameController");
    }

    public void setActiveSlot()
    {
        disableCurrentCategory();
        this.slot.SetActive(true);
        setCurrentCategory();
    }

    private void disableCurrentCategory()
    {
        this.storeController.GetComponent<StoreController>().getCurrentCategory().SetActive(false);
    }

    private void setCurrentCategory()
    {
        this.storeController.GetComponent<StoreController>().setCurrentCategory(this.slot);
    }
}
