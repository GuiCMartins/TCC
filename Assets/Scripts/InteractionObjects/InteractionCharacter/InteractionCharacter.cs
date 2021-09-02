using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCharacter : Interaction
{
    //Serialized fields
    [Header("Game Controller configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            firstQuest();
        }
    }

    private void firstQuest()
    {
        if (!this.initialQuest.getIsOpened())
        {
            this.initialQuest.startDialog();
        }
        else
        {
            if (this.initialQuest.getIsFightMonster())
            {
                if (!this.initialQuest.getAceptToTalkMom())
                {
                    this.initialQuest.startSecondDialog();
                } 
                else if (this.initialQuest.getIsTalkMom())
                {
                    Debug.Log("TUTORIAL");
                }
                else
                {
                    this.initialQuest.notTalkToMom();
                }
            }
            else
            {
                this.initialQuest.startOnGoingQuestDialog();
            }
        }
    }
}
