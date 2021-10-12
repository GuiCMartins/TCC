using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtackDamage : MonoBehaviour
{
    //Non serialized Fields
    private GameObject gameController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Monster" || collider.tag == "MonsterPoint" || collider.tag == "AmuletMonster")
        {
            int damage = this.gameController.GetComponent<GameController>().getPlayerAttackDamage();
            collider.gameObject.SendMessage("takeDamage", damage);
        }
    }
}
