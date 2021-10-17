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
    private float criticalDamagePercentBase = 0f;

    //Non serialized fields
    private GameObject gameController = null;
    [SerializeField]
    private int currentLife = 50;
    private int currentDamageMax = 10;
    private int currentDamageMin = 10;
    private int currentCriticalChance = 0;
    private int currentCriticalDamage = 0;
    private int moreLife = 0;
    private int moreDamage = 0;
    private int moreCriticalChance = 0;
    private float criticalDamagePercent = 0;
    private bool isPlayerDead = false;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");

        this.currentLife = this.totalLife;
        this.currentCriticalDamage = this.currentDamageMax + (int)(this.currentDamageMax * this.criticalDamagePercent);
    }

    //Function

    public void takeDamage(int damage)
    {
        if (!this.isPlayerDead)
        {
            if (this.gameController.GetComponent<GameController>().getPlayerCurrentLife() - damage > 0)
            {
                this.currentLife -= damage;
                this.gameController.GetComponent<GameController>().updatePlayerCurrentLife();
                this.gameController.GetComponent<HudController>().setLifeBar();
            }
            else
            {
                setIsPlayerDead(true);
                StartCoroutine(this.gameObject.GetComponent<PlayerController>().dead());
            }
        }
    }

    //Calculate

    public void calculateCriticalDamage()
    {
        this.currentCriticalDamage = getDamageMax() + (int)(getDamageMax() * this.criticalDamagePercent);
    }

    //Increase

    public void increaseTotalLife(int life)
    {
        this.totalLife = this.totalLife + life;
    }

    public void increaseCurrentLife(int life)
    {
        this.currentLife = this.currentLife + life;
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

    public void setCriticalDamagePercent(float criticalDamagePercent)
    {
        this.criticalDamagePercent = criticalDamagePercent;
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

    public void setBaseCriticalchance()
    {
        this.currentCriticalChance = this.criticalChanceBase;
    }

    public void setBaseCriticalDamagePercent()
    {
        this.criticalDamagePercent = this.criticalDamagePercentBase;
    }

    public void setIsPlayerDead(bool isPlayerDead)
    {
        this.isPlayerDead = isPlayerDead;
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
