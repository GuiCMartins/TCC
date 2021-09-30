using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeBarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setCurrentLife(float percentualLife)
    {
        this.gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(percentualLife, this.gameObject.transform.GetChild(0).gameObject.transform.localScale.y, 0);
    }
}
