using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTab : MonoBehaviour
{
    public void closeTab()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
