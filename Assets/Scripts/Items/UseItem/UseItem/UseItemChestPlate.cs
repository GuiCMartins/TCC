using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemChestPlate : UseItemBase
{
    public override void useItem(GameObject item)
    {
        Debug.Log("ChestPlate");
    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 1 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
