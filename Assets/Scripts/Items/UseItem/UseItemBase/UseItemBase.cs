using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UseItemBase : MonoBehaviour
{
    //Non serialized Fields
    private GameObject gameController = null;

    public abstract void useItem();
    public abstract void unUseItem();
    public abstract int[] getIdSlot();
    public abstract bool isConsumable();

    public void setGameController(GameObject gameController)
    {
        this.gameController = gameController;
    }

    public GameObject getGameController()
    {
        return this.gameController;
    }
}
