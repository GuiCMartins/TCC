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

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //teste de integração com a barra de vida do HUD
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.playerStats.takeDamage(7);
        }
        //Fim do teste

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
            interactionObj = collider.gameObject;
            collider.gameObject.SendMessage("setInteractiveComplements", true);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.tag == "InteractionObj")
        {
            rigidBody.WakeUp();           
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "InteractionObj")
        {
            interactionObj = null;
            collider.gameObject.SendMessage("setInteractiveComplements", false);
        }
    }

    private void callInteractionMethod()
    {
        if (interactionObj != null)
        {
            interactionObj.SendMessage("interaction");
        }
    }
}
