using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackAnimationTriggers : MonoBehaviour
{

    [Header("Projectile configuration")]
    [SerializeField]
    private GameObject projectile = null;

    public void turnAtackColliderOn()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void turnAtackColliderOff()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void atackRange()
    {
        Instantiate(this.projectile, transform.position, Quaternion.identity);
    }
}
