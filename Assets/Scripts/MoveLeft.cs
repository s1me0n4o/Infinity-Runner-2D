using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Vector2 negativeForce;
    [SerializeField]
    private float spownPointX = 7.4f;
    [SerializeField]
    private float spownPointY = 0.24f;

    private Rigidbody2D rb;
    private Vector3 currentScale;
    float[] scales = { 0.7f, 0.5f, 1f };

    public static bool endGame;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentScale = this.transform.localScale;
    }

    void Update()
    {
        if (!endGame)
        {
            AddObsticleMovements();
        }
    }

    private void AddObsticleMovements()
    {
        rb.AddForce(negativeForce * Time.deltaTime * speed);

        if (transform.position.x < -7)
        {
            RandomScale();
            transform.position = new Vector3(spownPointX, spownPointY, -1f);
        }
    }

    private void RandomScale()
    {
        int index = UnityEngine.Random.Range(0, 3);

        float newScale = scales[index];
        this.transform.localScale = currentScale * newScale;
    }
}
