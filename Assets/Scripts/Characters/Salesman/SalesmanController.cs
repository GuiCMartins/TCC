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
                bool isOpen = !this.store.activeSelf;
                this.store.SetActive(isOpen);

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
