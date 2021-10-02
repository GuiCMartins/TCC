using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionActivator : Interaction
{
    //Serialized fields
    [Header("Rune Configuration")]
    [SerializeField]
    private GameObject runeController = null;
    [Header("Door Configuration")]
    [SerializeField]
    private GameObject door = null;

    //Non serialized fields
    private Color[] color = new Color[4] { Color.cyan, Color.blue, Color.red, Color.green };
    private int colorCount = 0;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            changeLaserColor();

            if (this.runeController.GetComponent<RuneController>().isAllActivatorsRight())
            {
                this.door.GetComponent<Animator>().SetBool("IsOpen", true);
            }
        }
    }

    public Color getCurrentColor()
    {
        return color[colorCount];
    }

    private void changeLaserColor()
    {
        if(this.colorCount < 3)
        {
            this.colorCount++;
        }
        else
        {
            this.colorCount = 0;
        }
 
        this.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.SetColor("_Color", this.color[this.colorCount]);
    }
}
