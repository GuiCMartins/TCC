using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Serialized fields
    [Header("Scrip PlayerStats configuration")]
    [SerializeField]
    private PlayerStats playerStats = null;
    [Header("Quest configuration")]
    [SerializeField]
    private InitialQuest initialQuest = null;

    //Non serialized fields
    private Rigidbody2D rigidBody = null;
    private GameObject interactionObj = null;
    private GameObject gameController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
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

    public void dead()
    {
        this.gameObject.transform.position = this.gameController.GetComponent<GameController>().getCheckPoint().position;
        this.gameController.GetComponent<GameController>().setPlayerCurrentLife(this.gameController.GetComponent<GameController>().getPlayerTotalLife());
        this.gameController.GetComponent<GameController>().updatePlayerCurrentLife();
        this.gameController.GetComponent<HudController>().setLifeBar();
    }

    private void callInteractionMethod()
    {
        if (this.interactionObj != null)
        {
            this.interactionObj.SendMessage("interaction");
        }
    }
}
