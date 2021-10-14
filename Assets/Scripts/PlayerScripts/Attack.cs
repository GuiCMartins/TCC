using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //Non serialized fields
    private Animator animator = null;
    private bool isAtacking = false;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack(true);
        }
        else{
            attack(false);
        }
    }

    public bool getIsAtacking()
    {
        return this.isAtacking;
    }

    public void turnOnAttackDamage()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void turnOffAttackDamage()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void attack(bool isAtacking)
    {
        this.isAtacking = isAtacking;
        this.animator.SetBool("IsAtacking", isAtacking);
    }
}
