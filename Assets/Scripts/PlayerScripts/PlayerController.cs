using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Non serialized fields
    private Rigidbody2D rigidBody;
    [SerializeField]
    private GameObject interactionObj;

    //Serialized fields
    [Header("Scrip PlayerStats configuration")]
    [SerializeField]
    private PlayerStats playerStats = null;
    [Header("Quest configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        callInteractionMethod();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Collectable")
        {
            collider.gameObject.SendMessage("colect");
        }
        else if (collider.tag == "InteractionObj")
        {
            this.interactionObj = collider.gameObject;
            collider.gameObject.SendMessage("setInteractiveComplements", true);
        }
        else if (collider.tag == "Damage")
        {
            this.playerStats.takeDamage(7);
        }
        else if (collider.tag == "QuestPoint")
        {
            collider.gameObject.GetComponent<QuestPoint>().executeDialog();
            Destroy(collider.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.tag == "InteractionObj")
        {
            this.rigidBody.WakeUp();           
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "InteractionObj")
        {
            this.interactionObj = null;
            collider.gameObject.SendMessage("setInteractiveComplements", false);
        }
    }

    private void callInteractionMethod()
    {
        if (this.interactionObj != null)
        {
            this.interactionObj.SendMessage("interaction");
        }
    }
}
