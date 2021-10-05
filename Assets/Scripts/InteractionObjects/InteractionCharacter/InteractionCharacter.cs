using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCharacter : Interaction
{
    //Serialized fields
    [Header("Quest configuration")]
    [SerializeField]
    private QuestBase quest = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            firstQuest();
        }
    }

    private void firstQuest()
    {
        if (!this.quest.getIsCompleted())
        {
            this.quest.executeCurrentDialog();
        }
    }
}
