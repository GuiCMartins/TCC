using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackDamageRange : MonoBehaviour
{
    //Serialized Fields
    [Header("Player Configuration")]
    [SerializeField]
    private Transform player = null;
    [Header("Damage Configuration")]
    [SerializeField]
    private int damage = 5;

    //Non Serialized Fields
    private Vector3 playerPosition = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        this.playerPosition = this.player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, this.playerPosition, 0.5f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.SendMessage("takeDamage", this.damage);
        Destroy(this.gameObject);
    }
}
