using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItemHelmet : UseItemArmor
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
        int[] id = new int[1] { 0 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
