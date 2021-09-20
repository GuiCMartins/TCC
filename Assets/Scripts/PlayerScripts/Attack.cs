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
        if (Input.GetKeyDown(KeyCode.Mouse0))
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

    private void attack(bool isAtacking)
    {
        this.isAtacking = isAtacking;
        this.animator.SetBool("IsAtacking", isAtacking);
    }
}
