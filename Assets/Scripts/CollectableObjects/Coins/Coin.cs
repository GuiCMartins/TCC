using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : CollectableBase
{
    //Non serialized fields
    private GameController gameController;
    private Rigidbody2D rigidBody;

    //Serialized Fields
    [Header("Value configuration")]
    [SerializeField]
    private int value = 0;

    void Start()
    {
        gameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    public override void colect()
    {
        gameController.setPlayerCoins(this.value);
        Destroy(this.gameObject);
    }
}
