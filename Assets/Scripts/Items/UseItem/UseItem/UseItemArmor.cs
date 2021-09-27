using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UseItemArmor : UseItemBase
{
    //Serialized Fields
    [Header("Life stats configuration")]
    [SerializeField]
    private int moreLife = 50;

    public override abstract void useItem();
    public override abstract void unUseItem();
    public override abstract int[] getIdSlot();
    public override abstract bool isConsumable();

    public void useItemBase()
    {
        setGameController();
        increasePlayerLifeStats();
        updatePlayerLifeStats();
    }

    public void unUseItemBase()
    {
        setGameController();
        decreasePlayerLifeStats();
        updatePlayerLifeStats();
    }

    private void setGameController()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
    }

    private void increasePlayerLifeStats()
    {
        base.getGameController().GetComponent<GameController>().increasePlayerTotalLife(this.moreLife);
    }

    private void decreasePlayerLifeStats()
    {
        base.getGameController().GetComponent<GameController>().decreasePlayerTotalLife(this.moreLife);
    }

    private void updatePlayerLifeStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerTotalLife();
        base.getGameController().GetComponent<GameController>().setPlayerCurrentLife((int)(base.getGameController().GetComponent<GameController>().getPlayerTotalLife() * base.getGameController().GetComponent<HudController>().getLifeBarPercent()));
        base.getGameController().GetComponent<GameController>().updatePlayerCurrentLife();
        base.getGameController().GetComponent<HudController>().setLifeBar();
        //base.updatePlayerLife();
        //base.updatePlayerLifeBar();
    }
}
