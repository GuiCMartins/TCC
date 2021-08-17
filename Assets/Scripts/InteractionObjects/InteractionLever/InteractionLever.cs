using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionLever : Interaction
{
    //Serialized fields
    [SerializeField]
    private GameObject levers = null;

    private bool on = false;

    public override void interaction()
    {
        turnOnOffTheLever();
    }

    public bool getOn()
    {
        return this.on;
    }

    private void turnOnOffTheLever()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.on = !this.on;

            if (this.on)
            {
                this.levers.GetComponent<LeverController>().setLeverAux(this.gameObject);
            }
        }
    }
}
