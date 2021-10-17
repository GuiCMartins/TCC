using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    //Serialized fields
    [Header("Statues configuration")]
    [SerializeField]
    private GameObject[] statues = null;
    [Header("Door configuration")]
    [SerializeField]
    private GameObject door = null;

    //Non serialized fields
    private int[] finalUnlock = new int[4] { 3, 2, 2, 3 };
    private bool isDoorClose = true;
    private bool isGetTheAmulet = false;

    // Start is called before the first frame update
    void Start()
    {
        setFinalUnlock();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isDoorClose)
        {
            if (isAllStatuesRight() && isGetTheAmulet)
            {
                openDoor();
            }
        }
    }

    public void updateIsGetTheAmulet()
    {
        this.isGetTheAmulet = true;
    }

    private void openDoor()
    {
        this.isDoorClose = false;
        this.door.GetComponent<Animator>().SetBool("IsOpen", true);
        this.door.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void setFinalUnlock()
    {
        System.Random randomNumber = new System.Random();

        for (int i=2; i<this.finalUnlock.Length; i++)
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
