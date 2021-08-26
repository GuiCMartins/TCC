using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MovementBase
{
    void FixedUpdate()
    {
        if (!base.getIsFollowPlayer())
        {
            transform.position = Vector3.MoveTowards(transform.position, base.getMonsterPosition().position, base.getSpeed() * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        base.setMovementation();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player" && !base.getAnimator().GetBool("IsAtacking"))
        {
            base.setIsFollowPlayer(true);
            transform.position = Vector3.MoveTowards(transform.position, base.getPlayer().transform.position, base.getSpeed() * Time.deltaTime);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            base.setIsFollowPlayer(false);
        }
    }
}
