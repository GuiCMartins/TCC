using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    //Serialized fields
    [Header("End configuration")]
    [SerializeField]
    private GameObject end = null;

    public void endGame()
    {
        this.end.SetActive(true);
        Time.timeScale = 0;
    }
}
