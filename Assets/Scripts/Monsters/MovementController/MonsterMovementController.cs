using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MonoBehaviour
{
    //Serialized fields
    [Header("Player configuration")]
    [SerializeField]
    private GameObject player = null;
    [Header("Monster configuration")]
    [SerializeField]
    private Transform lentineoPosition = null;
    [SerializeField]
    private float speed = 0.1f;

    //Non serialized fields
    private bool isFollowPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!this.isFollowPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, lentineoPosition.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.isFollowPlayer = true;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.isFollowPlayer = false;
        }
    }
}
