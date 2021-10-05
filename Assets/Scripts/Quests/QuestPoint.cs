using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class QuestPoint : MonoBehaviour
{
    //Serialized fields
    [Header("Flowchart configuration")]
    [SerializeField]
    private Flowchart fC = null;
    [Header("Dialog configuration")]
    [SerializeField]
    private string dialog = null;

    public void executeDialog()
    {
        this.fC.ExecuteBlock(this.dialog);
    }
}
