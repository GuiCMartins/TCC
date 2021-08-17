using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    //Serialized fields
    [SerializeField]
    private GameObject[] levers = null;
    [SerializeField]
    private GameObject[] leversAux = new GameObject[3] { null, null, null };

    //Non serialized fields
    private int[] finalUnlock = new int[3] { 0, 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        setFinalUnlock();

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(this.finalUnlock[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeversAuxFull())
        {

            if (this.levers[this.finalUnlock[0]] == this.leversAux[0] && this.levers[this.finalUnlock[1]] == this.leversAux[1] && this.levers[this.finalUnlock[2]] == this.leversAux[2])
            {
                Debug.Log("BRABO!!!");
            }

            this.leversAux = new GameObject[] { null, null, null };
        }
    }

    private bool isLeversAuxFull()
    {
        if (this.leversAux[0] != null && this.leversAux[1] != null && this.leversAux[2] != null)
        {
            return true;
        }

        return false;
    }

    private void cancelTheSpears()
    {

    }

    private void setDifferentRandomNumberFromFirst(System.Random randomNumber)
    {
        do
        {
            this.finalUnlock[1] = randomNumber.Next(3);
        } while (this.finalUnlock[1] == this.finalUnlock[0]);
    }

    private void setDifferentRandomNumberFromSecondAndFirst(System.Random randomNumber)
    {
        do
        {
            this.finalUnlock[2] = randomNumber.Next(3);
        } while (this.finalUnlock[2] == this.finalUnlock[1] || this.finalUnlock[2] == this.finalUnlock[0]);
    }

    private void setFinalUnlock()
    {
        System.Random randomNumber = new System.Random();

        this.finalUnlock[0] = randomNumber.Next(3);
        setDifferentRandomNumberFromFirst(randomNumber);
        setDifferentRandomNumberFromSecondAndFirst(randomNumber);
    }

    public void setLeverAux(GameObject gameObject)
    {
        for (int i=0; i<this.leversAux.Length; i++)
        {
            if(this.leversAux[i] == null)
            {
                this.leversAux[i] = gameObject;
                break;
            }
        }
    }
}
