using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTab : MonoBehaviour
{
    //Serialized fields
    [Header("Item to close configuration")]
    [SerializeField]
    private GameObject itemToClose = null;

    public void chooseTab()
    {
        this.itemToClose.SetActive(false);
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    
}
