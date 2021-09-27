using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UseItemArmor : UseItemBase
{
    //Serialized Fields
    [Header("Stats configuration")]
    [SerializeField]
    private int moreLife = 50;

    public override abstract void useItem();
    public override abstract void unUseItem();
    public override abstract int[] getIdSlot();
    public override abstract bool isConsumable();

    public void useItemBase()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
        base.getGameController().GetComponent<GameController>().increasePlayerTotalLife(this.moreLife);
        base.updatePlayerLife();
        base.updatePlayerLifeBar();
    }

    public void unUseItemBase()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
        base.getGameController().GetComponent<GameController>().decreasePlayerTotalLife(this.moreLife);
        base.updatePlayerLife();
        base.updatePlayerLifeBar();
    }
}
