using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Vector2 jumpForce;
    [SerializeField]
    private LayerMask groundedLayerMask;

    private Rigidbody2D rb;
    private bool grounded;
    private bool jumping = false;
    private Collider2D playerCollider;

    private Animator anim;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        playerCollider = GetComponent<Collider2D>();

        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (!MoveLeft.endGame)
        {
            grounded = Physics2D.IsTouchingLayers(playerCollider, groundedLayerMask);

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && grounded)
            {
                rb.AddForce(jumpForce);
                jumping = true;

                //anim.SetBool("Jump", false);
            }

            if (grounded)
            {
                anim.SetBool("Jump", false);
            }
            else
            {
                anim.SetBool("Jump", true);
            }
        }
    }
}
        
