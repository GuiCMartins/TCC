using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialQuest : QuestBase
{
    //Non serialized fields
    private bool canOpenInventory = false;
    private bool isOpenInventory = false;
    private bool isOpenBestiary = false;
    private int countInv = 0;
    private int countBest = 0;

    void Update()
    {
        verifyIsOpenInventory();
        verifyIsOpenBestiary();
    }

    public override void setCurrentDialogId(int id)
    {
        base.setBaseCurrentDialogId(id);
    }

    public override void setOtherCharacterDialogId(int id)
    {
        base.setBaseOtherCharacterDialogId(id);
    }

    public void setCanOpenInventory()
    {
        this.canOpenInventory = true;
    } 

    private void verifyIsOpenInventory()
    {
        if (!this.isOpenInventory && this.canOpenInventory && Input.GetKeyDown(KeyCode.E))
        {
            setCurrentDialogId(1);
            base.executeCurrentDialog();
            this.isOpenInventory = true;
        }
    }

    private void verifyIsOpenBestiary()
    {
        if (!this.isOpenBestiary && this.isOpenInventory && Input.GetKeyDown(KeyCode.B))
        {
            setCurrentDialogId(2);
            base.executeCurrentDialog();
            this.isOpenBestiary = true;
        }
    }

    private void verifyIsOpenBoth()
    {
        if (this.isOpenBestiary && this.isOpenInventory)
        {

        }
    }
}
