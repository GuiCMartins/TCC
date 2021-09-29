using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTorch : Interaction
{
    //Serialized Fields
    [SerializeField]
    private bool on = true;

    void Start()
    {
        TurnOnOffLight();
    }

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            updateOn();
            TurnOnOffLight();
        }
    }

    private void TurnOnOffLight()
    {
            this.gameObject.transform.GetChild(4).gameObject.SetActive(this.on);
    }

    private void updateOn()
    {
        this.on = !this.on;
    }
}
