using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    //Non serialized fields
    private Vector2 position = Vector2.zero;
    private Rigidbody2D rigidBody = null;
    private Animator animator = null;
    private bool isLeft = false;

    //Serialized Fields
    [Header("Speed Configuration")]
    [SerializeField]
    private int speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.isLeft = false;
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

    public bool getIsLeft()
    {
        return this.isLeft;
    }

    private void setMovementation()
    {
        this.position.x = Input.GetAxis("Horizontal") * this.speed * Time.deltaTime;
        this.position.y = Input.GetAxis("Vertical") * this.speed * Time.deltaTime;

        if(this.position.x != 0 && !GetComponent<Attack>().getIsAtacking() || this.position.y != 0 && !GetComponent<Attack>().getIsAtacking())
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
        this.rigidBody.MovePosition(this.rigidBody.position + this.position);
    }

    private void WalkAnimation(bool isWalking)
    {
        this.animator.SetBool("IsWalking", isWalking);
    }

    private void flip()
    {
        if(this.position.x > 0 && this.isLeft || this.position.x < 0 && !this.isLeft)
        {

            this.isLeft = !this.isLeft;
            float x = this.gameObject.transform.localScale.x;
            x *= -1;

            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
            
        }
    }
}
