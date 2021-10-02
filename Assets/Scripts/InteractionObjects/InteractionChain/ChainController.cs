using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainController : MonoBehaviour
{
    //Serialized fields
    [Header("Bridges Configuration")]
    [SerializeField]
    private GameObject bridges = null;
    [Header("Water Configuration")]
    [SerializeField]
    private GameObject water = null;

    //Non serialized fields
    private System.Random randNum = new System.Random();
    private int[] chainsId = new int[4] { 0, 1, 2 , 3 };
    private int bridgeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        setChainsId();
    }

    public void turnOnTheBridge(int id)
    {
        if (this.chainsId[id] >= this.bridgeCount)
        {
            this.bridges.transform.GetChild(this.chainsId[id]).gameObject.SetActive(true);

            if (this.chainsId[id] != this.bridgeCount)
            {
                StartCoroutine("turnOffTheBridge", id);
            }
            else
            {
                this.bridgeCount++;
            }

            freeThePath();
        }
    }

    IEnumerator turnOffTheBridge(int id)
    {
        yield return new WaitForSeconds(1.5f);
        this.bridges.transform.GetChild(this.chainsId[id]).gameObject.SetActive(false);
    }

    private void freeThePath()
    {
        if (this.bridgeCount == 4)
        {
            this.water.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }

    private void setDifferentRandomNumberFromFirst(System.Random randomNumber)
    {
        do
        {
            this.chainsId[1] = randomNumber.Next(4);
        } while (this.chainsId[1] == this.chainsId[0]);
    }

    private void setDifferentRandomNumberFromSecondAndFirst(System.Random randomNumber)
    {
        do
        {
            this.chainsId[2] = randomNumber.Next(4);
        } while (this.chainsId[2] == this.chainsId[1] || this.chainsId[2] == this.chainsId[0]);
    }

    private void setDifferentRandomNumberFromThirdAndSecondAndFirst(System.Random randomNumber)
    {
        do
        {
            this.chainsId[3] = randomNumber.Next(4);
        } while (this.chainsId[3] == this.chainsId[2] || this.chainsId[3] == this.chainsId[1] || this.chainsId[3] == this.chainsId[0]);
    }

    private void setChainsId()
    {
        System.Random randomNumber = new System.Random();

        this.chainsId[0] = randomNumber.Next(4);
        setDifferentRandomNumberFromFirst(randomNumber);
        setDifferentRandomNumberFromSecondAndFirst(randomNumber);
        setDifferentRandomNumberFromThirdAndSecondAndFirst(randomNumber);
    }
}
