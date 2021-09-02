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
    private Flowchart[] fCs = null;
    [Header("Game Controller configuration")]
    [SerializeField]
    private GameController gameController = null;

    //Non serialized fields
    private bool isCompleted = false;
    private bool isOpened = false;

    public void setIsCompleted()
    {
        this.isCompleted = true;
    }

    public void setIsOpened()
    {
        this.isOpened = true;
    }

    public bool getIsCompleted()
    {
        return this.isCompleted;
    }

    public bool getIsOpened()
    {
        return this.isOpened;
    }

    public string[] getDialog()
    {
        return this.dialog;
    }

    public Flowchart[] getFC()
    {
        return this.fCs;
    }

    public GameController getGameController()
    {
        return this.gameController;
    }
}
