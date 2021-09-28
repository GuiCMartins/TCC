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
        curePlayer();
        updatePlayerLifeStats();
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

    public override bool isPlayerSpecificStatsNotFull()
    {
        base.setGameController();

        return isPlayerLifesNotFull();
    }

    private bool isPlayerLifesNotFull()
    {
        if (base.getGameController().GetComponent<GameController>().getPlayerCurrentLife() < base.getGameController().GetComponent<GameController>().getPlayerTotalLife())
        {
            return true;
        }

        return false;
    }

    private void curePlayer()
    {
        increasePlayerLifeStats(getLifeHeal());
    }

    private void increasePlayerLifeStats(int lifeHeal)
    {
        base.getGameController().GetComponent<GameController>().increasePlayerCurrentLife(lifeHeal);
    }

    private void updatePlayerLifeStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerCurrentLife();
        base.getGameController().GetComponent<HudController>().setLifeBar();
    }

    private int getLifeHeal()
    {
        float percentLifeHeal = (float)this.lifeHeal / 100;
        int lifeToHeal = (int)(base.getGameController().GetComponent<GameController>().getPlayerTotalLife() * percentLifeHeal);

        if (base.getGameController().GetComponent<GameController>().getPlayerCurrentLife() + lifeToHeal <= base.getGameController().GetComponent<GameController>().getPlayerTotalLife())
        {
            return lifeToHeal;
        }
        
        return base.getGameController().GetComponent<GameController>().getPlayerTotalLife() - base.getGameController().GetComponent<GameController>().getPlayerCurrentLife();
    }
}
