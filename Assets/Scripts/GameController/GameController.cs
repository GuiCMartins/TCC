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
    private GameObject player = null;
    private int playerCoins = 0;
    private int playerXp = 0;
    [SerializeField]
    private int playerCurrentLife = 0;
    [SerializeField]
    private int playerTotalLife = 0;
    [SerializeField]
    private int playerTotalDamage = 0;
    private int questId = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindWithTag("Player");

        updatePlayerCurrentLife();
        updatePlayerTotalLife();
        this.playerTotalDamage = this.player.GetComponent<PlayerStats>().getTotalDamage();
    }

    public void setPlayerCurrentLife(int life)
    {
        this.player.GetComponent<PlayerStats>().setCurrentLife(life);
    }

    public void updatePlayerCurrentLife()
    {
        this.playerCurrentLife = this.player.GetComponent<PlayerStats>().getCurrentLife();
    }

    public void updatePlayerTotalLife()
    {
        this.playerTotalLife = this.player.GetComponent<PlayerStats>().getTotalLife();
    }

    public void increasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().increaseTotalLife(life);
    }

    public void decreasePlayerTotalLife(int life)
    {
        this.player.GetComponent<PlayerStats>().decreaseTotalLife(life);
    }

    public void setPlayerCoins(int valueCoin)
    {
        this.playerCoins += valueCoin;
    }

    public void setQuestId(int questId)
    {
        this.questId = questId;
    }

    public int getPlayerCoins()
    {
        return this.playerCoins;
    }

    public int getPlayerTotalLife()
    {
        return this.playerTotalLife;
    }

    public int getPlayerTotalDamage()
    {
        return this.playerTotalDamage;
    }

    public int getPlayerXp()
    {
        return this.playerXp;
    }

    public int getPlayerCurrentLife()
    { 
        return this.playerCurrentLife;
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
