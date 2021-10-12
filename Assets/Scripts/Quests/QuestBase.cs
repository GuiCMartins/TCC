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
    [Header("Entrance configuration")]
    [SerializeField]
    private GameObject nextEntrance = null;
    [Header("Amulet quest id configuration")]
    [SerializeField]
    private int[] idAmulet = new int[2];

    //Non serialized fields
    private GameObject gameController = null;
    private bool isCompleted = false;
    private int currentDialogId = 0;
    private int otherCharacterDialogId = 0;
    private bool isGetFirstAmulet = false;
    private bool isGetSecondAmulet = false;

    public abstract void setCurrentDialogId(int id);
    public abstract void setOtherCharacterDialogId(int id);

    public bool verifyAmulet(int id)
    {
        if (getGameController().transform.GetChild(1).GetComponent<Inventory>().getAmuletInInventory(id) != null)
        {
            return true;
        }

        return false;
    }

    public GameObject getGameController()
    {
        return this.gameController;
    }

    public void setGameController(GameObject gameController)
    {
        this.gameController = gameController;
    }

    public int getIdAmulet(int id)
    {
        return this.idAmulet[id];
    }

    public bool getIsGetFirstAmulet()
    {
        return this.isGetFirstAmulet;
    }

    public void updateIsGetFirstAmulet()
    {
        this.isGetFirstAmulet = true;
    }

    public bool getIsGetSecondAmulet()
    {
        return this.isGetSecondAmulet;
    }

    public void updateIsGetSecondAmulet()
    {
        this.isGetSecondAmulet = true;
    }

    public void setIsCompleted()
    {
        this.isCompleted = true;
        Destroy(this);
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

    public void activateNextEntrance()
    {
        this.nextEntrance.SetActive(true);
    }
}
