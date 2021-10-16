using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestBookTextController : MonoBehaviour
{
    //Serialized Fields
    [Header("Quest Text Configuration")]
    [SerializeField]
    private GameObject[] quests = new GameObject[6];
    //Non serialized fields
    private int countQuestText = 0;
    private int countCurrentQuest = 0;

    public void changeColortextToCompletedMission()
    {
        this.quests[this.countCurrentQuest].transform.GetChild(this.countQuestText).GetComponent<TextMeshProUGUI>().color = Color.green;
        this.countQuestText++;
    }

    public void apearNewMission()
    {
        this.quests[this.countCurrentQuest].transform.GetChild(this.countQuestText).gameObject.SetActive(true);
    }

    public void completedQuest()
    {
        this.countQuestText = 0;
        desactiveQuestBooktext();
        this.countCurrentQuest++;
        activeQuestBooktext();
    }

    private void activeQuestBooktext()
    {
        this.quests[this.countCurrentQuest].SetActive(true);
    }

    private void desactiveQuestBooktext()
    {
        this.quests[this.countCurrentQuest].SetActive(false);
    }
}
