using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemLifePotion : UseItemBase
{
    public override void useItem()
    {
        Debug.Log("LifePotion");
    }

    public override void unUseItem()
    {

    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 0 };

        return id;
    }

    public override bool isConsumable()
    {
        return true;
    }
}
