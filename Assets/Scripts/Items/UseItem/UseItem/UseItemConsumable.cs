using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UseItemConsumable : UseItemBase
{
    public override abstract void useItem();
    public override abstract void unUseItem();
    public override abstract int[] getIdSlot();
    public override abstract bool isConsumable();
    public abstract bool isPlayerSpecificStatsNotFull();

    public void useItemBase()
    {
        setGameController();
    }

    public void unUseItemBase()
    {
        destroyConsumable();
    }

    public GameObject getGameController()
    {
        return base.getGameController();
    }

    public void setGameController()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
    }

    private void destroyConsumable()
    {
        Destroy(this.gameObject);
    }
}
