using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMonsterPoint : MonoBehaviour
{
    //Serialized fields
    [Header("Quest configuration")]
    [SerializeField]
    private QuestBase quest = null;
    [Header("Quest id configuration")]
    [SerializeField]
    private int questId = 0;

    public void setCurrentDialogId()
    {
        quest.setBaseCurrentDialogId(this.questId);
    }
}
