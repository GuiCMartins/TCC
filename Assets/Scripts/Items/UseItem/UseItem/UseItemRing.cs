using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemRing : UseItemBase
{
    public override void useItem(GameObject item)
    {
       
    }

    public override int[] getIdSlot()
    {
        int[] id = new int[2] { 4, 5 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
