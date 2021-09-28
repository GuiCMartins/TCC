using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemLifePotion : UseItemConsumable
{
    [Header("Life heal configuration")]
    [SerializeField]
    private int lifeHeal = 20;

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
        return true;
    }
}
