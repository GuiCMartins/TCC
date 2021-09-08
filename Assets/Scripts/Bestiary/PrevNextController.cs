﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevNextController : MonoBehaviour
{
    //Serialized Fields
    [Header("Pages configuration")]
    [SerializeField]
    private GameObject[] pages = new GameObject[3];

    //Non Serialized Fields
    private int countPages = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.pages[0].SetActive(true);
        this.pages[1].SetActive(false);
        this.pages[2].SetActive(false);
        this.pages[3].SetActive(false);
        this.pages[4].SetActive(false);
        this.pages[5].SetActive(false);
        this.pages[6].SetActive(false);
        this.pages[7].SetActive(false);
        this.pages[8].SetActive(false);
    }

    public void nextPage()
    {
        if(this.countPages < 8)
        {
            this.pages[this.countPages].SetActive(false);
            this.countPages++;
            this.pages[this.countPages].SetActive(true);
        }
    }

    public void prevPage()
    {
        if (this.countPages > 0)
        {
            this.pages[this.countPages].SetActive(false);
            this.countPages--;
            this.pages[this.countPages].SetActive(true);
        }
    }
}
