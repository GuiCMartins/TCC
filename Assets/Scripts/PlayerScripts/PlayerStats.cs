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
    private int damageMax = 10;
    [SerializeField]
    private int damageMin = 10;
    [SerializeField]
    private int criticalChance = 0;
    [SerializeField]
    private int criticalDamage = 0;

    //Non serialized fields
    private GameObject gameController = null;
    private int currentLife = 50;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");

        this.currentLife = this.totalLife;
    }

    public void takeDamage(int damage)
    {
        this.currentLife -= damage;
        this.gameController.GetComponent<GameController>().updatePlayerCurrentLife();
        this.gameController.GetComponent<HudController>().setLifeBar();
    }

    public void setCurrentLife(int life)
    {
        this.currentLife = life;
    }

    public void increaseTotalLife(int life)
    {
        this.totalLife = this.totalLife + life;
    }

    public void decreaseTotalLife(int life)
    {
        this.totalLife = this.totalLife - life;
    }

    public void setTotalLife(int totalLife)
    {
        this.totalLife = totalLife;
    }

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
        return this.damageMax;
    }

    public int getDamageMin()
    {
        return this.damageMin;
    }

    public int getCriticalDamage()
    {
        return this.criticalDamage;
    }

    public int getCriticalChance()
    {
        return this.criticalChance;
    }
}
