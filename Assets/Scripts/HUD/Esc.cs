using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    //Serialized Fields
    [Header("Esc configuration")]
    [SerializeField]
    private GameObject esc = null;

    // Start is called before the first frame update
    void Start()
    {
        this.esc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        openEsc();
    }

    private void openEsc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.esc.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
