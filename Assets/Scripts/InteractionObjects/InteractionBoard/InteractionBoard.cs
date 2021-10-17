using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBoard : Interaction
{
    //Serialized fields
    [Header("Board Panel Configuration")]
    [SerializeField]
    private GameObject BordPanel = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            turnOnBoardPanel();
        }
    }

    private void turnOnBoardPanel()
    {
        this.BordPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
