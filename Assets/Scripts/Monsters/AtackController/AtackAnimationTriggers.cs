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

    IEnumerator atackRange()
    {
        GameObject p = Instantiate(this.projectile, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Destroy(p);
    }
}
