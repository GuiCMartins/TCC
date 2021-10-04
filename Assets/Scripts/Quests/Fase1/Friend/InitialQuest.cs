using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : QuestBase
{
    //Non Serialized Fields
    private int currentDialogId = 0;

    public void setCurrentDialogId(int id)
    {
        this.currentDialogId = id;
    }

    public int getCurrentDialogId()
    {
        return this.currentDialogId;
    }

    public void executeCurrentDialog()
    {
        this.getFC().ExecuteBlock(this.getDialog()[this.getCurrentDialogId()]);
    }
}
