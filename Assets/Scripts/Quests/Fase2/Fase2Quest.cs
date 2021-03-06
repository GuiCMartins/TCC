using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase2Quest : QuestBase
{
    //Serialized fields
    [Header("Monster configuration")]
    [SerializeField]
    private List<GameObject> monsters = new List<GameObject>();
    [Header("Fence configuration")]
    [SerializeField]
    private List<GameObject> fences = new List<GameObject>();

    //Non serialized fields
    private bool isFirstMonterDead = false;
    private bool isLastMonterDead = false;

    // Start is called before the first frame update
    void Start()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
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

        if (!base.getIsGetFirstAmulet() && base.verifyAmulet(base.getIdAmulet(0)))
        {
            base.updateIsGetFirstAmulet();
            setCurrentDialogId(2);
            base.executeCurrentDialog();
        }

        if (!base.getIsGetSecondAmulet() && base.verifyAmulet(base.getIdAmulet(1)))
        {
            base.updateIsGetSecondAmulet();
            setCurrentDialogId(3);
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

    public void openFences()
    {
        this.fences[0].GetComponent<Animator>().SetBool("IsOpen", true);
        this.fences[1].GetComponent<Animator>().SetBool("IsOpen", true);
    }
}
