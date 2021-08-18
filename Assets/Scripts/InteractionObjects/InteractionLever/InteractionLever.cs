using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionLever : Interaction
{
    //Serialized fields
    [SerializeField]
    private GameObject levers = null;

    private bool on = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

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
                turnOnOffAnimation(true);
                this.levers.GetComponent<LeverController>().setLeverAux(this.gameObject);
            }
            else
            {
                turnOnOffAnimation(false);
            }
        }
    }

    private void turnOnOffAnimation(bool isTurnOn)
    {
        animator.SetBool("IsTurnOn", isTurnOn);
    }

}
