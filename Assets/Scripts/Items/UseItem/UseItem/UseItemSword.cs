using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemSword : UseItemBase
{
    public override void useItem()
    {
        Debug.Log("Sword");
    }

    public override void unUseItem()
    {

    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 3 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
