using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackController : MonoBehaviour
{
    //Serialized Fields
    [Header("Speed Configuration")]
    [SerializeField]
    private int damage = 5;
    [Header("Animator Configuration")]
    [SerializeField]
    private Animator animator = null;
    [Header("Player configuration")]
    [SerializeField]
    private GameObject player = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (Math.Abs(this.gameObject.transform.position.x - this.player.transform.position.x) < 0.1 && Math.Abs(this.gameObject.transform.position.y - this.player.transform.position.y) < 0.2)
            {
                this.animator.SetBool("IsAtacking", true);
            }
            else
            {
                this.animator.SetBool("IsAtacking", false);
            }
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
