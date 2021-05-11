using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : QuestBase
{
    public override void startQuest()
    {
        if (this == this.getGameController().getQuestBase()[0]) {
            setIsOpened();
        }
    }

    public override void startDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[0]);
    }

    public override void startOnGoingQuestDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[1]);
    }

    public override void startQuestCompletedDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[3]);
        Destroy(this);
    }

    public void thanksForTheBook()
    {
        if (this.getIsOpened()) {
            this.getFC()[1].ExecuteBlock(this.getDialog()[2]);
        }
    }
}
