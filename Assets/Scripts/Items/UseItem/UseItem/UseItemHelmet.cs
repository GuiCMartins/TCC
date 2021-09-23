using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItemHelmet : UseItemBase
{
    public override void useItem(GameObject item)
    {
        Sprite helmetSprite = GameObject.FindWithTag("HelmetIcon").GetComponent<Image>().sprite;

        if(helmetSprite == null)
        {
            helmetSprite = item.GetComponent<SpriteRenderer>().sprite;
        }
    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 0 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
