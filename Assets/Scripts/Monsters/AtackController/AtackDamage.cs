using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackDamage : MonoBehaviour
{
    //Serialized Fields
    [Header("Damage Configuration")]
    [SerializeField]
    private int damage = 5;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.SendMessage("takeDamage", this.damage);
        }
    }
}
