using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MovementBase
{
    void FixedUpdate()
    {
        if (!base.getIsFollowPlayer())
        {
            this.gameObject.transform.parent.position = Vector3.MoveTowards(transform.position, base.getMonsterPosition().position, base.getSpeed() * Time.deltaTime);
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
            this.gameObject.transform.parent.position = Vector3.MoveTowards(transform.position, new Vector3(base.getPlayer().transform.position.x, base.getPlayer().transform.position.y, 0), base.getSpeed() * Time.deltaTime);
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
