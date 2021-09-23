using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemBoots : UseItemBase
{
    
    public override void useItem(GameObject item)
    {
        Debug.Log("Boots");
    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 2 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
