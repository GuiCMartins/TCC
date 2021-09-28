using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemRing : UseItemEnchantment
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
        int[] id = new int[2] { 4, 5 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
