﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackController : MonoBehaviour
{
    //Serialized Fields
    [Header("Animator Configuration")]
    [SerializeField]
    private Animator animator = null;
    [Header("Player configuration")]
    [SerializeField]
    private GameObject player = null;
    [Header("Projectile configuration")]
    [SerializeField]
    private GameObject projectile = null;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (Math.Abs(this.gameObject.transform.position.x - this.player.transform.position.x) < 0.1 && Math.Abs(this.gameObject.transform.position.y - this.player.transform.position.y) < 0.3)
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