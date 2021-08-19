using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    //Serialized fields
    [Header("Statues configuration")]
    [SerializeField]
    private GameObject[] statues = null;

    //Non serialized fields
    private int[] finalUnlock = new int[4] { 0, 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        setFinalUnlock();

        Debug.Log("Segundo puzzle");

        for (int i = 0; i < 4; i++)
        {
            Debug.Log(this.finalUnlock[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAllStatuesRight())
        {
            Debug.Log("Abre a porta!!");
        }
    }

    private void setFinalUnlock()
    {
        System.Random randomNumber = new System.Random();

        for (int i=0; i<this.finalUnlock.Length; i++)
        {
            this.finalUnlock[i] = randomNumber.Next(4);
        }
    }

    private bool isAllStatuesRight()
    {
        for(int i=0; i<this.statues.Length; i++)
        {
            if (this.statues[i].GetComponent<InteractionStatue>().getNextStatueSprite() != this.finalUnlock[i])
            {
                return false;
            }
        }

        return true;
    }
}
