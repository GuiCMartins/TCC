using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : QuestBase
{
    //Non Serialized Fields
    private int currentDialogId = 0;
    private int otherCharacterDialogId = 0;

    public void setCurrentDialogId(int id)
    {
        this.currentDialogId = id;
    }

    public void setOtherCharacterDialogId(int id)
    {
        this.otherCharacterDialogId = id;
    }

    public int getCurrentDialogId()
    {
        return this.currentDialogId;
    }

    public int getOtherCharacterDialogId()
    {
        return this.otherCharacterDialogId;
    }

    public void executeCurrentDialog()
    {
        this.getFC().ExecuteBlock(this.getDialog()[this.getCurrentDialogId()]);
    }

    public void executeOtherCharacterDialogId()
    {
        this.getFC().ExecuteBlock(this.getDialog()[this.getOtherCharacterDialogId()]);
    }
}
