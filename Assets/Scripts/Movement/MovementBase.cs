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
        if (this.gameObject.transform.position.x != this.monsterPosition.position.x || this.gameObject.transform.position.y != this.monsterPosition.position.y)
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
        if (this.gameObject.transform.position.x < this.player.transform.position.x && this.isLeft || this.gameObject.transform.position.x > this.player.transform.position.x && !this.isLeft)
        {

            this.isLeft = !this.isLeft;
            float x = this.gameObject.transform.localScale.x;
            x *= -1;

            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);

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
