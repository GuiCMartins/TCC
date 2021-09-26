using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalesmanController : Interaction
{
    //Serialized Fields
    [Header("Store configuration")]
    [SerializeField]
    private GameObject store = null;

    public override void interaction()
    {
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.store.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
}
