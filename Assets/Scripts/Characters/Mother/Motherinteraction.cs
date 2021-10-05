using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motherinteraction : Interaction
{
    //Serialized fields
    [Header("Quest configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.initialQuest.getOtherCharacterDialogId() == 4)
            {
                this.initialQuest.executeOtherCharacterDialog();
            }
        }
    }
}
