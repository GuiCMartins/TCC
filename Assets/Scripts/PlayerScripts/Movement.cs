using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Non serialized fields
    private Vector2 position = Vector2.zero;
    private Rigidbody2D rigidBody;
    private Animator animator;
    private bool isLeft;

    //Serialized Fields
    [Header("Speed Configuration")]
    [SerializeField]
    private int speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isLeft = false;
    }

    void FixedUpdate()
    {
        move();
    }

    // Update is called once per frame
    void Update()
    {
        setMovementation();
    }

    private void setMovementation()
    {
        position.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if(position.x != 0 || position.y != 0)
        {
            flip();
            WalkAnimation(true);
        }
        else
        {
            WalkAnimation(false);
        }
    }

    private void move()
    {
        rigidBody.MovePosition(rigidBody.position + position);
    }

    private void WalkAnimation(bool isWalking)
    {
        animator.SetBool("IsWalking", isWalking);
    }

    private void flip()
    {
        if(position.x > 0 && isLeft || position.x < 0 && !isLeft)
        {

            isLeft = !isLeft;
            float x = this.gameObject.transform.localScale.x;
            x *= -1;

            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
            
        }
    }
}
