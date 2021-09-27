using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemChestPlate : UseItemArmor
{
    public override void useItem()
    {
        base.useItemBase();
    }

    public override void unUseItem()
    {
        base.unUseItemBase();
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
