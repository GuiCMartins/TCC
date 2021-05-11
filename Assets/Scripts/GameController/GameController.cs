using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Non serialized fields
    private int playerCoins = 0;
    private int playerXp = 0;
    [SerializeField]
    private int playerCurrentLife = 0;
    private int questId = 0;

    //Serialized fields
    [Header("Base player life configuration")]
    [SerializeField]
    private int basePlayerLife;
    [Header("Base player damage configuration")]
    [SerializeField]
    private int basePlayerDamage;
    [Header("Quests configuration")]
    [SerializeField]
    private List<QuestBase> quests = new List<QuestBase>();

    // Start is called before the first frame update
    void Start()
    {
        this.playerCurrentLife = this.basePlayerLife;

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayerCoins(int valueCoin)
    {
        this.playerCoins += valueCoin;
    }

    public void setBasePlayerLife(int baseLife)
    {
        this.basePlayerLife = baseLife;
    }

    public void setBasePlayerDamage(int baseDamage)
    {
        this.basePlayerDamage = baseDamage;
    }

    public void setPlayerXp(int xp)
    {
        this.playerXp = xp;
    }

    public void setPlayerCurrentLife(int playerCurrentLife)
    {
        this.playerCurrentLife = playerCurrentLife;
    }

    public void setQuestId(int questId)
    {
        this.questId = questId;
    }

    public int getPlayerCoins()
    {
        return this.playerCoins;
    }

    public int getBasePlayerLife()
    {
        return this.basePlayerLife;
    }

    public int getBasePlayerDamage()
    {
        return this.basePlayerDamage;
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
