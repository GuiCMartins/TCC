using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : Interaction
{
    //Non serialize fields
    private SpriteRenderer spriteRenderer;
    private bool isClosed = true;

    //Serialize fields
    [Header("Sprites chest configuration")]
    [SerializeField]
    private Sprite[] spritesChest = null;
    [Header("Coin configuration")]
    [SerializeField]
    private GameObject[] coins = null;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void interaction()
    {
        openChest();
    }

    private void openChest()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (this.isClosed)
            {
                this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
                this.isClosed = false;
                this.spriteRenderer.sprite = this.spritesChest[1];
                drop();
            }
        }
    }

    private void drop()
    {
        int numberofCoin = 0;

        for (int i = 0; i < 3; i++)
        {
            int randomNumber = Random.Range(1,100);

            if (randomNumber < 60)
            {
                numberofCoin = 0;
            }
            else if (randomNumber < 90)
            {
                numberofCoin = 1;
            }
            else
            {
                numberofCoin = 2;
            }

            Instantiate(this.coins[numberofCoin], this.gameObject.transform.position, Quaternion.identity);
        }
    }
}
