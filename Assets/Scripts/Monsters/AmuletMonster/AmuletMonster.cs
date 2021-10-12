using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmuletMonster : MonoBehaviour
{
    //Serialized fields
    [Header("Amulet configuration")]
    [SerializeField]
    private GameObject amuletToDrop = null;

    public void dropAmulet()
    {
        Instantiate(this.amuletToDrop, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0) , Quaternion.identity);
    }
}
