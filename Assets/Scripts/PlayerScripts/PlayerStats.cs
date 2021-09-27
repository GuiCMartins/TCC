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

    //Decrease

    public void decreaseTotalLife(int life)
    {
        this.totalLife = this.totalLife - life;
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
        return this.totalLife;
    }

    public int getCurrentLife()
    {
        return this.currentLife;
    }

    public int getDamageMax()
    {
        return this.currentDamageMax;
    }

    public int getDamageMin()
    {
        return this.currentDamageMin;
    }

    public int getCriticalDamage()
    {
        return this.currentCriticalDamage;
    }

    public int getCriticalChance()
    {
        return this.currentCriticalChance;
    }
}
