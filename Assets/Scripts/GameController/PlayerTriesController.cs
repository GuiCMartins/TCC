using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriesController : MonoBehaviour
{
    [Header("Restart panel configuration")]
    [SerializeField]
    private GameObject restartPanel = null;
    [Header("Life Count configuration")]
    [SerializeField]
    private GameObject lifeCount = null;

    //Non serialized fields
    private int tries = 3;

    // Update is called once per frame
    void Update()
    {
        if (this.tries == 0)
        {
            this.restartPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void updateTries()
    {
        this.lifeCount.GetComponent<LifeCount>().lifeLost(this.tries-1);
        this.tries--;
    }
}
