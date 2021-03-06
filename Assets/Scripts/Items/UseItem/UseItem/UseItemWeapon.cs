using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UseItemWeapon : UseItemBase
{
    //Serialized Fields
    [Header("Damage stats configuration")]
    [SerializeField]
    private int damageMin = 20;
    [SerializeField]
    private int damageMax = 40;
    [SerializeField]
    private int criticalchance = 10;
    [SerializeField]
    private int criticalDamage = 15;

    public override abstract void useItem();
    public override abstract void unUseItem();
    public override abstract int[] getIdSlot();
    public override abstract bool isConsumable();

    public void useItemBase()
    {
        setGameController();
        setPlayerDamageStats();
        calculatePlayerDamageStats();
        updatePlayerDamageStats();
    }

    public void unUseItemBase()
    {
        setGameController();
        setBasePlayerDamageStats();
        calculatePlayerDamageStats();
        updatePlayerDamageStats();
    }

    private void setGameController()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
    }

    private void calculatePlayerDamageStats()
    {
        base.getGameController().GetComponent<GameController>().calculatePlayerCriticalDamage();
    }

    private void setPlayerDamageStats()
    {
        base.getGameController().GetComponent<GameController>().setPlayerDamageMin(this.damageMin);
        base.getGameController().GetComponent<GameController>().setPlayerDamageMax(this.damageMax);
        base.getGameController().GetComponent<GameController>().setPlayerCriticalDamagePercent(((float)criticalDamage / (float)100));
        base.getGameController().GetComponent<GameController>().setPlayerCriticalchance(this.criticalchance);
    }

    private void setBasePlayerDamageStats()
    {
        base.getGameController().GetComponent<GameController>().setBasePlayerDamageMin();
        base.getGameController().GetComponent<GameController>().setBasePlayerDamageMax();
        base.getGameController().GetComponent<GameController>().setBasePlayerCriticalDamagePercent();
        base.getGameController().GetComponent<GameController>().setBasePlayerCriticalchance();
    }

    private void updatePlayerDamageStats()
    {
        base.getGameController().GetComponent<GameController>().updatePlayerDamageMin();
        base.getGameController().GetComponent<GameController>().updatePlayerDamageMax();
        base.getGameController().GetComponent<GameController>().updatePlayerCriticalDamage();
        base.getGameController().GetComponent<GameController>().updatePlayerCriticalChance();
    }
}
