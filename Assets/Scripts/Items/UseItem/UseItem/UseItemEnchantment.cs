using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UseItemEnchantment : UseItemBase
{
    //Serialized Fields
    [Header("Life stats configuration")]
    [SerializeField]
    private int moreLife = 50;
    [Header("Damage stats configuration")]
    [SerializeField]
    private int moreDamage = 10;
    [SerializeField]
    private int moreCriticalChance = 5;

    public override abstract void useItem();
    public override abstract void unUseItem();
    public override abstract int[] getIdSlot();
    public override abstract bool isConsumable();

    public void useItemBase()
    {
        setGameController();
        increasePlayerMoreLifeStats();
        increasePlayerMoreDamageStats();
        updatePlayerMoreLifeStats();
        updatePlayerMoreDamageStats();
        updatePlayerLifeStats();
        updatePlayerDamageStats();
    }

    public void unUseItemBase()
    {
        setGameController();
        decreasePlayerMoreLifeStats();
        decreasePlayerMoreDamageStats();
        updatePlayerMoreLifeStats();
        updatePlayerMoreDamageStats();
        updatePlayerLifeStats();
        updatePlayerDamageStats();
    }

    private void setGameController()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
    }

    private void increasePlayerMoreLifeStats()
    {
        base.getGameController().GetComponent<GameController>().increasePlayerMoreLife(this.moreLife);
    }

    private void increasePlayerMoreDamageStats()
    {
        base.getGameController().GetComponent<GameController>().increasePlayerMoreDamage(this.moreDamage);
        base.getGameController().GetComponent<GameController>().increasePlayerMoreCriticalChance(this.moreCriticalChance);
    }

    private void decreasePlayerMoreLifeStats()
    {
        base.getGameController().GetComponent<GameController>().decreasePlayerMoreLife(this.moreLife);
    }

    private void decreasePlayerMoreDamageStats()
    {
        base.getGameController().GetComponent<GameController>().decreasePlayerMoreDamage(this.moreDamage);
        base.getGameController().GetComponent<GameController>().decreasePlayerMoreCriticalChance(this.moreCriticalChance);
    }

    private void updatePlayerLifeStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerTotalLife();
        base.getGameController().GetComponent<GameController>().setPlayerCurrentLife((int)(base.getGameController().GetComponent<GameController>().getPlayerTotalLife() * base.getGameController().GetComponent<HudController>().getLifeBarPercent()));
        base.getGameController().GetComponent<GameController>().updatePlayerCurrentLife();
        base.getGameController().GetComponent<HudController>().setLifeBar();
    }

    private void updatePlayerMoreLifeStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerMoreLife();
    }

    private void updatePlayerDamageStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerDamageMin();
        base.getGameController().GetComponent<GameController>().updatePlayerDamageMax();
        base.getGameController().GetComponent<GameController>().updatePlayerCriticalChance();
    }

    private void updatePlayerMoreDamageStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerMoreDamage();
        base.getGameController().GetComponent<GameController>().updatePlayerMoreCriticalChance();
    }
}
