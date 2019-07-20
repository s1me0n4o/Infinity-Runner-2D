using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    private int speed = 5;
    private float spownPointX = 6.6f;
    private float spownPointY;

    // Update is called once per frame
    void Update()
    {
        speed = UnityEngine.Random.Range(1, 10);
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        spownPointY = UnityEngine.Random.Range(-2.7f, 2f);

        ReplaceCoin();

    }

    public void ReplaceCoin()
    {
        if (transform.position.x < -7)
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
            transform.position = new Vector3(spownPointX, spownPointY, -1f);
        }
    }
}
