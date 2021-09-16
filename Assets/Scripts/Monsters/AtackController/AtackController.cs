using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackController : MonoBehaviour
{
    //Serialized Fields
    [Header("Animator Configuration")]
    [SerializeField]
    private Animator animator = null;

    void onTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.animator.SetBool("IsAtacking", true);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.animator.SetBool("IsAtacking", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.animator.SetBool("IsAtacking", false);
        }
    }
}
