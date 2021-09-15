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
    private GameObject monster = null;
    [Header("Key Configuration")]
    [SerializeField]
    private GameObject key = null;

    //Non serialized fields
    private string[] graves = new string[10] { "Grave1", "Grave2", "Grave3", "Grave4", "Grave5", "Grave6", "Grave7", "Grave8", "Grave9", "Grave10" };
    private bool[] keys = new bool[10] { false, false, false, true, false, false, false, false, false, false };

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
        for (int i=0; i<this.graves.Length;i++)
        {
            if(this.graves[i] == this.gameObject.name)
            {
                if(this.keys[i] == false)
                {
                    Instantiate(this.monster, transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(this.key, transform.position, Quaternion.identity);
                }
            }
        } 
    }
}
