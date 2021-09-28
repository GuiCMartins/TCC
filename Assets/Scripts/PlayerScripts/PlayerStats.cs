using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Serialized fields
    [SerializeField]
    [Header("Life configuration")]
    private int totalLife = 50;
    [Header("Damage configuration")]
    [SerializeField]
    private int damageMaxBase = 10;
    [SerializeField]
    private int damageMinBase = 10;
    [SerializeField]
    private int criticalChanceBase = 0;
    [SerializeField]
    private int criticalDamageBase = 0;

    //Non serialized fields
    private GameObject gameController = null;
    private int currentLife = 50;
    private int currentDamageMax = 10;
    private int currentDamageMin = 10;
    private int currentCriticalChance = 0;
    private int currentCriticalDamage = 0;
    private int moreLife = 0;
    private int moreDamage = 0;
    private int moreCriticalChance = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");

        this.currentLife = this.totalLife;
    }

    //Function

    public void takeDamage(int damage)
    {
        this.currentLife -= damage;
        this.gameController.GetComponent<GameController>().updatePlayerCurrentLife();
        this.gameController.GetComponent<HudController>().setLifeBar();
    }

    //Increase

    public void increaseTotalLife(int life)
    {
        this.totalLife = this.totalLife + life;
    }

    public void increaseMoreLife(int life)
    {
        this.moreLife = this.moreLife + life;
    }

    public void increaseMoreDamage(int damage)
    {
        this.moreDamage = this.moreDamage + damage;
    }

    public void increaseDamage(int damage)
    {
        setDamageMin(damage);
        setDamageMax(damage);
    }

    public void increaseMoreCriticalChance(int criticalChance)
    {
        this.moreCriticalChance = this.moreCriticalChance + criticalChance;
    }

    public void increaseCriticalChance(int criticalChance)
    {
        this.currentCriticalChance = this.currentCriticalChance + criticalChance;
    }

    //Decrease

    public void decreaseTotalLife(int life)
    {
        this.totalLife = this.totalLife - life;
    }

    public void decreaseMoreLife(int life)
    {
        this.moreLife = this.moreLife - life;
    }

    public void decreaseMoreDamage(int damage)
    {
        this.moreDamage = this.moreDamage - damage;
    }

    public void decreaseMoreCriticalChance(int criticalChance)
    {
        this.moreCriticalChance = this.moreCriticalChance - criticalChance;
    }

    //Set

    public void setTotalLife(int totalLife)
    {
        this.totalLife = totalLife;
    }

    public void setCurrentLife(int life)
    {
        this.currentLife = life;
    }

    public void setDamageMin(int damageMin)
    {
        this.currentDamageMin = damageMin;
    }

    public void setDamageMax(int damageMax)
    {
        this.currentDamageMax = damageMax;
    }

    public void setCriticalDamage(int criticalDamage)
    {
        this.currentCriticalDamage = criticalDamage;
    }

    public void setCriticalchance(int criticalChance)
    {
        this.currentCriticalChance = criticalChance;
    }

    public void setBaseDamageMin()
    {
        this.currentDamageMin = this.damageMinBase;
    }

    public void setBaseDamageMax()
    {
        this.currentDamageMax = this.damageMaxBase;
    }

    public void setBaseCriticalDamage()
    {
        this.currentCriticalDamage = this.criticalDamageBase;
    }

    public void setBaseCriticalchance()
    {
        this.currentCriticalChance = this.criticalChanceBase;
    }

    //Get

    public int getTotalLife()
    {
        return this.totalLife + this.moreLife;
    }

    public int getCurrentLife()
    {
        return this.currentLife;
    }

    public int getMoreLife()
    {
        return this.moreLife;
    }

    public int getDamageMax()
    {
        return this.currentDamageMax + this.moreDamage;
    }

    public int getDamageMin()
    {
        return this.currentDamageMin + this.moreDamage;
    }

    public int getMoreDamage()
    {
        return this.moreDamage;
    }

    public int getCriticalDamage()
    {
        return this.currentCriticalDamage;
    }

    public int getCriticalChance()
    {
        return this.currentCriticalChance + this.moreCriticalChance;
    }

    public int getMoreCriticalChance()
    {
        return this.moreCriticalChance;
    }
}
