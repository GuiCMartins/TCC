using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestiaryController : MonoBehaviour
{
    //Serialized Fields
    [Header("Bestiary configuration")]
    [SerializeField]
    private GameObject bestiary = null;

    // Start is called before the first frame update
    void Start()
    {
        this.bestiary.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        openBestiary();
    }

    private void openBestiary()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.bestiary.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
