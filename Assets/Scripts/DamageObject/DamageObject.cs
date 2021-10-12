using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    [Header("Damage configuration")]
    [SerializeField]
    private int damage = 20;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.SendMessage("takeDamage", this.damage);
        }
    }
}
