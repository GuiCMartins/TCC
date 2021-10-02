using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void disableProperties()
    {
        this.gameObject.transform.GetComponent<BoxCollider2D>().enabled = false;
    }
}
