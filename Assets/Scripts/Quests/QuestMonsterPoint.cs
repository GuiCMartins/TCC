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
    [Header("Quest Text configuration")]
    [SerializeField]
    private GameObject questText = null;

    public void setCurrentDialogId()
    {
        quest.setBaseCurrentDialogId(this.questId);
    }

    public GameObject getQuestText()
    {
        return this.questText;
    }
}
