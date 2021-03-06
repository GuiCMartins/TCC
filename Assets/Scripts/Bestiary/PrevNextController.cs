using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevNextController : MonoBehaviour
{
    //Serialized Fields
    [Header("Pages configuration")]
    [SerializeField]
    private GameObject[] pages = new GameObject[8];

    //Non Serialized Fields
    private int countPages = 0;

    // Start is called before the first frame update
    void Start()
    {

        foreach (GameObject page in this.pages)
        {
            page.SetActive(false);
        }

        this.pages[0].SetActive(true);
    }

    public void nextPage()
    {
        if(this.countPages < this.pages.Length - 1)
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
