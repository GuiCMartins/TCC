using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCharacter : Interaction
{
    //Serialized fields
    [Header("Game Controller configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            firstQuest();
        }
    }

    private void firstQuest()
    {
        if (!this.initialQuest.getIsCompleted())
        {
            if (this.initialQuest.getIsCurrentDialog())
            {
                this.initialQuest.executeCurrentDialog();
            }
            else
            {
                this.initialQuest.executeOtherCharacterDialogId();
            }
        }
    }
}
