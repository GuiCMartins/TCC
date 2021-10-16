using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionGrave : Interaction
{
    //Serialized fields
    [Header("Animator Configuration")]
    [SerializeField]
    private Animator animator = null;
    [Header("Monster Configuration")]
    [SerializeField]
    private GameObject obj = null;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            broke();
        }
    }

    private void broke()
    {
        this.animator.SetBool("IsBroke", true);
        setUntagged();
        dropKeyOrMonster();
    }

    private void setUntagged()
    {
        this.gameObject.tag = "Untagged";
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }

    private void dropKeyOrMonster()
    {
        Instantiate(this.obj, transform.position, Quaternion.identity);
    }
}
