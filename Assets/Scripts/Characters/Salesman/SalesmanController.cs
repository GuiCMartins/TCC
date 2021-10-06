using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalesmanController : Interaction
{
    //Serialized Fields
    [Header("Store configuration")]
    [SerializeField]
    private GameObject store = null;
    [Header("Tutorial quest configuration")]
    [SerializeField]
    private QuestBase quest = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.quest.getCurrentDialogId() == 3)
            {
                this.quest.setCurrentDialogId(4);
            }

            this.store.SetActive(true);
            Time.timeScale = 0;
        }   
    }
}
