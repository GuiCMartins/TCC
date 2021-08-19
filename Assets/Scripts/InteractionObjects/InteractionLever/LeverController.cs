using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    //Serialized fields
    [Header("Levers configuration")]
    [SerializeField]
    private GameObject[] levers = null;
    [SerializeField]
    private GameObject[] leversAux = new GameObject[3] { null, null, null };
    [Header("Spears configuration")]
    [SerializeField]
    private GameObject[] spears = null;

    //Non serialized fields
    private int[] finalUnlock = new int[3] { 0, 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        setFinalUnlock();

        Debug.Log("Primeiro puzzle");

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
                cancelTheSpears();
            }

            this.leversAux = new GameObject[] { null, null, null };
            turnAllLeversOff();
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

    private void turnAllLeversOff()
    {
        this.levers[0].GetComponent<InteractionLever>().turnOnOffAnimation(false);
        this.levers[1].GetComponent<InteractionLever>().turnOnOffAnimation(false);
        this.levers[2].GetComponent<InteractionLever>().turnOnOffAnimation(false);
    }

    private void cancelTheSpears()
    {
        this.spears[0].GetComponent<Animator>().SetBool("IsTurnOff", true);
        this.spears[1].GetComponent<Animator>().SetBool("IsTurnOff", true);
        this.spears[2].GetComponent<Animator>().SetBool("IsTurnOff", true);
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

    public void removeLeverAux(GameObject gameObject)
    {
        for (int i = 0; i < this.leversAux.Length; i++)
        {
            if (this.leversAux[i] == gameObject)
            {
                this.leversAux[i] = null;
                break;
            }
        }
    }
}
