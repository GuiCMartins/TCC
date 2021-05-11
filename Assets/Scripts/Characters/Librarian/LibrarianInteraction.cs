using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianInteraction : Interaction
{
    //Serialized fields
    [Header("Quests configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    public override void interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            initialQuest.thanksForTheBook();
        }
    }
}
