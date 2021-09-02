using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondQuest : QuestBase
{
    public void startQuest()
    {
        if (this == this.getGameController().getQuestBase()[0])
        {
            setIsOpened();
        }
    }

    public void startDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[0]);
    }

    public void startOnGoingQuestDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[1]);
    }

    public void startQuestCompletedDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[3]);
        Destroy(this);
    }
}
