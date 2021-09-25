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
        openCloseInventory();
    }

    private void openCloseInventory()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            bool isOpen = !this.bestiary.activeSelf;
            this.bestiary.SetActive(isOpen);

            if (isOpen)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
