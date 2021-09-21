using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementBase : MonoBehaviour
{
    //Non serialized fields
    private bool isLeft = false;
    private Vector2 position = Vector2.zero;
    private bool isFollowPlayer = false;

    //Serialized Fields
    [Header("Speed Configuration")]
    [SerializeField]
    private float speed = 0.1f;
    [Header("Animator Configuration")]
    [SerializeField]
    private Animator animator = null;
    [Header("Player configuration")]
    [SerializeField]
    private GameObject player = null;
    [Header("Monster configuration")]
    [SerializeField]
    private Transform monsterPosition = null;

    public void setMovementation()
    {
        if (this.gameObject.transform.parent.position.x != this.monsterPosition.position.x && !this.animator.GetBool("IsAtacking") || this.gameObject.transform.parent.position.y != this.monsterPosition.position.y && !this.animator.GetBool("IsAtacking"))
        {
            if (this.isFollowPlayer)
            {
                flip();
            }
            WalkAnimation(true);
        }
        else
        {
            WalkAnimation(false);
        }
    }

    public void flip()
    {
        if (this.gameObject.transform.parent.position.x < this.player.transform.position.x && this.isLeft || this.gameObject.transform.parent.position.x > this.player.transform.position.x && !this.isLeft)
        {

            this.isLeft = !this.isLeft;
            float x = this.gameObject.transform.parent.localScale.x;
            x *= -1;

            this.gameObject.transform.parent.localScale = new Vector3(x, this.gameObject.transform.parent.localScale.y, this.gameObject.transform.parent.localScale.z);

        }
    }

    public void WalkAnimation(bool isWalking)
    {
        this.animator.SetBool("IsWalking", isWalking);
    }

    public float getSpeed()
    {
        return this.speed;
    }

    public GameObject getPlayer()
    {
        return this.player;
    }

    public Transform getMonsterPosition()
    {
        return this.monsterPosition;
    }

    public bool getIsFollowPlayer()
    {
        return this.isFollowPlayer;
    }

    public void setIsFollowPlayer(bool isFollowPlayer)
    {
        this.isFollowPlayer = isFollowPlayer;
    }

    public Animator getAnimator()
    {
        return this.animator;
    }
}
