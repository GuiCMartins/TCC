using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase4Quest : QuestBase
{
    //Serialized fields
    [Header("Monster configuration")]
    [SerializeField]
    private List<GameObject> monsters = new List<GameObject>();
    [Header("Door configuration")]
    [SerializeField]
    private GameObject door = null;

    //Non serialized fields
    private bool isFirstMonterDead = false;
    private bool isLastMonterDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isFirstMonterDead && this.monsters[0] == null)
        {
            this.isFirstMonterDead = true;
            setCurrentDialogId(0);
            base.executeCurrentDialog();
        }

        if (!this.isLastMonterDead && this.monsters[1] == null)
        {
            this.isLastMonterDead = true;
            setCurrentDialogId(1);
            base.executeCurrentDialog();
        }
    }

    public override void setCurrentDialogId(int id)
    {
        base.setBaseCurrentDialogId(id);
    }

    public override void setOtherCharacterDialogId(int id)
    {
        base.setBaseOtherCharacterDialogId(id);
    }

    private void openDoor()
    {
        this.door.transform.GetComponent<Animator>().SetBool("IsOpen", true);
    }
}
