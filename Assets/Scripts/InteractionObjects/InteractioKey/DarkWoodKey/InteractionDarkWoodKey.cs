using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDarkWoodKey : Interaction
{
    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Open the door!");
            Destroy(this.gameObject);
        }
    }
}
