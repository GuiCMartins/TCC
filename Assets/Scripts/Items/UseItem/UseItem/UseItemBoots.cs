using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemBoots : UseItemBase
{ 
    //Serialized Fields
    [Header("Stats configuration")]
    [SerializeField]
    private int moreLife = 40;

    public override void useItem()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
        base.getGameController().GetComponent<GameController>().increasePlayerTotalLife(this.moreLife);
        base.updatePlayerLife();
        base.updatePlayerLifeBar();
    }

    public override void unUseItem()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
        base.getGameController().GetComponent<GameController>().decreasePlayerTotalLife(this.moreLife);
        base.updatePlayerLife();
        base.updatePlayerLifeBar();
    }

    public override int[] getIdSlot()
    {
        int[] id = new int[1] { 2 };

        return id;
    }

    public override bool isConsumable()
    {
        return false;
    }
}
