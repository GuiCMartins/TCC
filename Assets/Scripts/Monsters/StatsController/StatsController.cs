using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    //Serialized fields
    [Header("Life Configuration")]
    [SerializeField]
    private GameObject lifeBar = null;
    [SerializeField]
    private int totalLife = 20;
    [SerializeField]
    private int currentLife = 20;

    public void takeDamage(int damage)
    {
        this.currentLife -= damage;

        if (this.currentLife > 0) {
            float percent = (float)this.currentLife / this.totalLife;

            this.lifeBar.GetComponent<lifeBarController>().setCurrentLife(percent);
        }
        else
        {
            if (this.gameObject.tag == "MonsterPoint")
            {
                this.gameObject.GetComponent<QuestMonsterPoint>().setCurrentDialogId();
                this.gameObject.GetComponent<QuestMonsterPoint>().getQuestText().GetComponent<QuestBookTextController>().changeColortextToCompletedMission();
                this.gameObject.GetComponent<QuestMonsterPoint>().getQuestText().GetComponent<QuestBookTextController>().apearNewMission();
            }
            else if (this.gameObject.tag == "AmuletMonster")
            {
                this.gameObject.SendMessage("dropAmulet");
            }
            this.lifeBar.GetComponent<lifeBarController>().setCurrentLife(0);
            Destroy(this.gameObject);
        }
    }
}
