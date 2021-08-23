using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionStatue : Interaction
{
    //Serialized fields
    [Header("Sprite configuration")]
    [SerializeField]
    private Sprite[] sprites = null;

    //Non serialized fields
    private int nextStatueSprite = 0;

    public override void interaction()
    {
        rotateStatue();
    }

    private void rotateStatue()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(this.nextStatueSprite == 3)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = this.sprites[this.nextStatueSprite];
                this.nextStatueSprite = 0;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = this.sprites[this.nextStatueSprite];
                this.nextStatueSprite++;
            }
        }
    }

    public int getNextStatueSprite()
    {
        return this.nextStatueSprite;
    }
}
