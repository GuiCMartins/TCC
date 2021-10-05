using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public abstract class QuestBase : MonoBehaviour
{
    //Serialized fields
    [Header("Dialog configuration")]
    [SerializeField]
    private string[] dialog = null;
    [Header("Flowchart configuration")]
    [SerializeField]
    private Flowchart fC = null;
    [SerializeField]
    private Flowchart nextFC = null;

    //Non serialized fields
    private bool isCompleted = false;
    private int currentDialogId = 0;
    private int otherCharacterDialogId = 0;

    public abstract void setCurrentDialogId(int id);
    public abstract void setOtherCharacterDialogId(int id);

    public void setIsCompleted()
    {
        this.isCompleted = true;
    }

    public void setBaseCurrentDialogId(int id)
    {
        this.currentDialogId = id;
    }

    public void setBaseOtherCharacterDialogId(int id)
    {
        this.otherCharacterDialogId = id;
    }

    public bool getIsCompleted()
    {
        return this.isCompleted;
    }

    public string[] getDialog()
    {
        return this.dialog;
    }

    public Flowchart getFC()
    {
        return this.fC;
    }

    public int getCurrentDialogId()
    {
        return this.currentDialogId;
    }

    public int getOtherCharacterDialogId()
    {
        return this.otherCharacterDialogId;
    }

    public void executeCurrentDialog()
    {
        this.getFC().ExecuteBlock(this.getDialog()[this.getCurrentDialogId()]);
    }

    public void executeOtherCharacterDialog()
    {
        this.getFC().ExecuteBlock(this.getDialog()[this.getOtherCharacterDialogId()]);
    }

    public void disableThisFlowChart()
    {
        this.fC.gameObject.SetActive(false);
    }

    public void activateNextFlowChart()
    {
        this.nextFC.gameObject.SetActive(true);
    }
}
