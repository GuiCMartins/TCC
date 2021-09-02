using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : QuestBase
{
    //Non Serialized Fields
    private bool isFightMonster = false;
    private bool aceptToTalkMom = false;
    private bool isTalkMom = false;

    public void startQuest()
    {
        setIsOpened();
    }

    public void startDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[0]);
    }

    public void startSecondDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[1]);
    }

    public void startOnGoingQuestDialog()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[2]);
    }

    public void notTalkToMom()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[3]);
    }

    public void talkToMom()
    {
        this.getFC()[0].ExecuteBlock(this.getDialog()[4]);
    }

    public void setIsFightMonster()
    {
        this.isFightMonster = true;
    }

    public void setIsTalkMom()
    {
        this.isTalkMom = true;
    }

    public void setAceptToTalkMom()
    {
        this.aceptToTalkMom = true;
    }

    public bool getIsFightMonster()
    {
        return this.isFightMonster;
    }

    public bool getIsTalkMom()
    {
        return this.isTalkMom;
    }

    public bool getAceptToTalkMom()
    {
        return this.aceptToTalkMom;
    }
}
