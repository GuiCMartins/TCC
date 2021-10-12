using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase1Quest : QuestBase
{
    //Serialized fields
    [Header("Monsters configuration")]
    [SerializeField]
    private List<GameObject> monsters = new List<GameObject>();

    //Non serialized fields
    private bool isAllMonterDead = false;
    private bool isLastMonterDead = false;

    // Start is called before the first frame update
    void Start()
    {
        base.setGameController(GameObject.FindWithTag("GameController"));
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isAllMonterDead && verifyMonsterDead())
        {
            this.isAllMonterDead = true;
            setCurrentDialogId(0);
            base.executeCurrentDialog();
        }

        if (!this.isLastMonterDead && this.monsters[3] == null)
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

    public void setIsCompleted()
    {
        base.setIsCompleted();
    }

    private bool verifyMonsterDead()
    {
        for (int i=0; i<3; i++)
        {
            if (this.monsters[i] != null)
            {
                return false;
            }
        }

        return true;
    }
}
