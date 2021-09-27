using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Serialized fields
    [Header("Quests configuration")]
    [SerializeField]
    private List<QuestBase> quests = new List<QuestBase>();

    //Non serialized fields
    private System.Random randNum = new System.Random();
    private GameObject player = null;
    private int playerCoins = 0;
    private int playerXp = 0;
    [SerializeField]
    private int playerCurrentLife = 0;
    [SerializeField]
    private int playerTotalLife = 0;
    [SerializeField]
    private int playerDamageMax = 0;
    [SerializeField]
    private int playerDamageMin = 0;
    [SerializeField]
    private int playerCriticalChance = 0;
    [SerializeField]
    private int playerCriticalDamage = 0;
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

    //Update

    public void updatePlayerCurrentLife()
    {
        this.playerCurrentLife = this.player.GetComponent<PlayerStats>().getCurrentLife();
    }

    public void updatePlayerTotalLife()
    {
        this.playerTotalLife = this.player.GetComponent<PlayerStats>().getTotalLife();
    }

    public void updatePlayerDamageMax()
    {
        this.playerDamageMax = this.player.GetComponent<PlayerStats>().getDamageMax();
    }

    public void updatePlayerDamageMin()
    {
        this.playerDamageMin = this.player.GetComponent<PlayerStats>().getDamageMin();
    }

    public void updatePlayerCriticalDamage()
    {
        this.playerCriticalDamage = this.player.GetComponent<PlayerStats>().getCriticalDamage();
    }

    public void updatePlayerCriticalChance()
    {
        this.playerCriticalChance = this.player.GetComponent<PlayerStats>().getCriticalChance();
    }

    //Increase

    public void increasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().increaseTotalLife(life);
    }

    //Decrease

    public void decreasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().decreaseTotalLife(life);
    }

    //Set

    public void setPlayerCoins(int valueCoin)
    {
        this.playerCoins += valueCoin;
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

    public void setPlayerCriticalDamage(int criticalDamage)
    {
        this.player.GetComponent<PlayerStats>().setCriticalDamage(criticalDamage);
    }

    public void setPlayerCriticalchance(int criticalchance)
    {
        this.player.GetComponent<PlayerStats>().setCriticalchance(criticalchance);
    }

    public void setBasePlayerDamageMin()
    {
        this.player.GetComponent<PlayerStats>().setBaseDamageMin();
    }

    public void setBasePlayerDamageMax()
    {
        this.player.GetComponent<PlayerStats>().setBaseDamageMax();
    }

    public void setBasePlayerCriticalDamage()
    {
        this.player.GetComponent<PlayerStats>().setBaseCriticalDamage();
    }

    public void setBasePlayerCriticalchance()
    {
        this.player.GetComponent<PlayerStats>().setBaseCriticalchance();
    }

    //Get

    public int getPlayerDamageMax()
    {
        return this.playerDamageMax;
    }

    public int getPlayerDamageMin()
    {
        return this.playerDamageMin;
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
