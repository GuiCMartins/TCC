using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionChain : Interaction
{
    //Serialized fields
    [Header("Id Configuration")]
    [SerializeField]
    private int idBridge = 0;
    [Header("Bridge Configuration")]
    [SerializeField]
    private GameObject chains = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            turnOnTheBridge();
        }
    }

    private void turnOnTheBridge()
    {
        this.chains.GetComponent<ChainController>().turnOnTheBridge(this.idBridge);
    }
}
