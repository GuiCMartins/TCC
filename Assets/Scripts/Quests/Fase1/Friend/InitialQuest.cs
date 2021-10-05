using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : QuestBase
{
    [Header("Quest points configuration")]
    [SerializeField]
    private GameObject questPoint = null;
    [Header("Quest points configuration")]
    [SerializeField]
    private GameObject monster = null;

    public override void setCurrentDialogId(int id)
    {
        base.setBaseCurrentDialogId(id);
    }

    public override void setOtherCharacterDialogId(int id)
    {
        base.setBaseOtherCharacterDialogId(id);
    }

    public void activateQuestPoint()
    {
        this.questPoint.SetActive(true);
    }

    public void activateMonster()
    {
        this.monster.SetActive(true);
    }
}
