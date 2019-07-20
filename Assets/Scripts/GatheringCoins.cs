using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatheringCoins : MonoBehaviour
{

    private Coins coin;

    private void Start()
    {
        coin = GetComponent<Coins>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 0)
        {
            coin.GetComponent<SpriteRenderer>().enabled = false;
            PlayerStats.score += 10;
            coin.ReplaceCoin();
        }
    }
}
