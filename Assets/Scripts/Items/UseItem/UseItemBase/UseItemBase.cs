using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UseItemBase : MonoBehaviour
{
    //Non serialized fields
    private GameObject item = null;

    public abstract void useItem(GameObject item);
    public abstract int[] getIdSlot();
    public abstract bool isConsumable();
}
