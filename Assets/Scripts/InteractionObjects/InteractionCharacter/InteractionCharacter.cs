using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCharacter : Interaction
{
    //Serialized fields
    [Header("Game Controller configuration")]
    [SerializeField]
    private GameController gameController = null;

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
            if (!gameController.getQuestBase()[0].getIsOpened()) {
                gameController.getQuestBase()[0].startDialog();
            }
            else
            {
                if (gameController.getQuestBase()[0].getIsCompleted())
                {
                    gameController.getQuestBase()[0].startQuestCompletedDialog();
                    gameController.getQuestBase().RemoveAt(0);
                }
                else
                {
                    gameController.getQuestBase()[0].startOnGoingQuestDialog();
                }
            }
        }
    }
}
