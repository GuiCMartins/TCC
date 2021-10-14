using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Serialized fields
    [Header("Quests configuration")]
    [SerializeField]
    private List<QuestBase> quests = new List<QuestBase>();
    [Header("CheckPoint configuration")]
    [SerializeField]
    private Transform checkPoint = null;

    //Non serialized fields
    //Objects
    private System.Random randNum = new System.Random();
    private GameObject player = null;
    //playerStats
    private int playerCoins = 0;
    private int playerXp = 0;
    private int playerCurrentLife = 0;
    private int playerTotalLife = 0;
    private int playerMoreLife = 0;
    private int playerDamageMax = 0;
    private int playerDamageMin = 0;
    private int playerCriticalChance = 0;
    private int playerCriticalDamage = 0;
    private int playerMoreDamage = 0;
    private int playerMoreCriticalChance = 0;
    private int questId = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindWithTag("Player");

        updatePlayerCurrentLife();
        updatePlayerTotalLife();
        updatePlayerDamageMax();
        updatePlayerDamageMin();
        updatePlayerCriticalDamage();
        updatePlayerCriticalChance();
    }

    //Calculate

    public void calculatePlayerCriticalDamage()
    {
        this.player.GetComponent<PlayerStats>().calculateCriticalDamage();
    }

    //Update

    public void updatePlayerCurrentLife()
    {
        this.playerCurrentLife = this.player.GetComponent<PlayerStats>().getCurrentLife();
        this.gameObject.GetComponent<HudController>().setCurrentLifeText();
    }

    public void updatePlayerTotalLife()
    {
        this.playerTotalLife = this.player.GetComponent<PlayerStats>().getTotalLife();
        this.gameObject.GetComponent<HudController>().setTotalLifeText();
    }

    public void updatePlayerMoreLife()
    {
        this.playerMoreLife = this.player.GetComponent<PlayerStats>().getMoreLife();
    }

    public void updatePlayerDamageMax()
    {
        this.playerDamageMax = this.player.GetComponent<PlayerStats>().getDamageMax();
        this.gameObject.GetComponent<HudController>().setDamageMaxText();
    }

    public void updatePlayerDamageMin()
    {
        this.playerDamageMin = this.player.GetComponent<PlayerStats>().getDamageMin();
        this.gameObject.GetComponent<HudController>().setDamageMinText();
    }

    public void updatePlayerMoreDamage()
    {
        this.playerMoreDamage = this.player.GetComponent<PlayerStats>().getMoreDamage();
    }

    public void updatePlayerCriticalDamage()
    {
        this.playerCriticalDamage = this.player.GetComponent<PlayerStats>().getCriticalDamage();
        this.gameObject.GetComponent<HudController>().setCriticalDamageText();
    }

    public void updatePlayerCriticalChance()
    {
        this.playerCriticalChance = this.player.GetComponent<PlayerStats>().getCriticalChance();
        this.gameObject.GetComponent<HudController>().setCriticalChanceText();
    }

    public void updatePlayerMoreCriticalChance()
    {
        this.playerMoreCriticalChance = this.player.GetComponent<PlayerStats>().getMoreCriticalChance();
    }

    //Increase

    public void increasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().increaseTotalLife(life);
    }

    public void increasePlayerCurrentLife(int life)
    {
        this.player.GetComponent<PlayerStats>().increaseCurrentLife(life);
    }

    public void increasePlayerMoreLife(int life)
    {
        this.player.GetComponent<PlayerStats>().increaseMoreLife(life);
    }

    public void increasePlayerMoreDamage(int damage)
    {
        this.player.GetComponent<PlayerStats>().increaseMoreDamage(damage);
    }

    public void increasePlayerDamage(int damage)
    {
        this.player.GetComponent<PlayerStats>().increaseDamage(damage);
    }

    public void increasePlayerMoreCriticalChance(int critcalDamage)
    {
        this.player.GetComponent<PlayerStats>().increaseMoreCriticalChance(critcalDamage);
    }

    public void increasePlayerCriticalChance(int critcalDamage)
    {
        this.player.GetComponent<PlayerStats>().increaseCriticalChance(critcalDamage);
    }

    //Decrease

    public void decreasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().decreaseTotalLife(life);
    }

    public void decreasePlayerMoreLife(int life)
    {
        this.player.GetComponent<PlayerStats>().decreaseMoreLife(life);
    }

    public void decreasePlayerMoreDamage(int damage)
    {
        this.player.GetComponent<PlayerStats>().decreaseMoreDamage(damage);
    }

    public void decreasePlayerMoreCriticalChance(int critcalDamage)
    {
        this.player.GetComponent<PlayerStats>().decreaseMoreCriticalChance(critcalDamage);
    }

    //Set

    public void setPlayerCoins(int valueCoin)
    {
        this.playerCoins += valueCoin;
    }

    public void setCheckPoint(Transform checkPoint)
    {
        this.checkPoint = checkPoint;
    }

    public void setQuestId(int questId)
    {
        this.questId = questId;
    }

    public void setPlayerCurrentLife(int life)
    {
        this.player.GetComponent<PlayerStats>().setCurrentLife(life);
    }

    public void setPlayerDamageMin(int damageMin)
    {
        this.player.GetComponent<PlayerStats>().setDamageMin(damageMin);
    }

    public void setPlayerDamageMax(int damageMax)
    {
        this.player.GetComponent<PlayerStats>().setDamageMax(damageMax);
    }

    public void setPlayerCriticalchance(int criticalchance)
    {
        this.player.GetComponent<PlayerStats>().setCriticalchance(criticalchance);
    }

    public void setPlayerCriticalDamagePercent(float criticalDamagePercent)
    {
        this.player.GetComponent<PlayerStats>().setCriticalDamagePercent(criticalDamagePercent);
    }

    public void setBasePlayerDamageMin()
    {
        this.player.GetComponent<PlayerStats>().setBaseDamageMin();
    }

    public void setBasePlayerDamageMax()
    {
        this.player.GetComponent<PlayerStats>().setBaseDamageMax();
    }

    public void setBasePlayerCriticalchance()
    {
        this.player.GetComponent<PlayerStats>().setBaseCriticalchance();
    }

    public void setBasePlayerCriticalDamagePercent()
    {
        this.player.GetComponent<PlayerStats>().setBaseCriticalDamagePercent();
    }

    //Get

    public Transform getCheckPoint()
    {
        return this.checkPoint;
    }

    public int getPlayerDamageMax()
    {
        return this.playerDamageMax;
    }

    public int getPlayerDamageMin()
    {
        return this.playerDamageMin;
    }

    public int getPlayerCriticalDamage()
    {
        return this.playerCriticalDamage;
    }

    public int getPlayerCriticalChance()
    {
        return this.playerCriticalChance;
    }

    public int getPlayerCoins()
    {
        return this.playerCoins;
    }

    public int getPlayerTotalLife()
    {
        return this.playerTotalLife;
    }

    public int getPlayerXp()
    {
        return this.playerXp;
    }

    public int getPlayerCurrentLife()
    { 
        return this.playerCurrentLife;
    }

    public int getPlayerAttackDamage()
    {
        int chance = randNum.Next(1, 101);

        if (chance <= this.playerCriticalChance)
        {
            return this.playerCriticalDamage;
        }

        return randNum.Next(this.playerDamageMin, this.playerDamageMax + 1);
    }

    public int getQuestId()
    {
        return this.questId;
    }

    public List<QuestBase> getQuestBase()
    {
        return this.quests;
    }
}
