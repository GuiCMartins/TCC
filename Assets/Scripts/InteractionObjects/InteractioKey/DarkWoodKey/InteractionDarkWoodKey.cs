using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDarkWoodKey : Interaction
{
    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Find("Fence1").GetComponent<Animator>().SetBool("IsOpen", true);
            GameObject.Find("Fence2").GetComponent<Animator>().SetBool("IsOpen", true);
            Destroy(this.gameObject);
        }
    }
}
