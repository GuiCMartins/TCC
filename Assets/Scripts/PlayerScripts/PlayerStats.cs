using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Non serialized fields
    [SerializeField]
    private GameController gameController;
    [SerializeField]
    private int totalLife;
    [SerializeField]
    private int currentLife;
    [SerializeField]
    private int currentDamage;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = FindObjectOfType(typeof(GameController)) as GameController;
        this.totalLife = this.gameController.getBasePlayerLife();
        this.currentLife = this.gameController.getPlayerCurrentLife();
        this.currentDamage = this.gameController.getBasePlayerDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        this.currentLife -= damage;
        this.gameController.setPlayerCurrentLife(this.currentLife);
    }

    public int getTotalLife()
    {
        return this.totalLife;
    }

    public int getCurrentLife()
    {
        return this.currentLife;
    }
}
