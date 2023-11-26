using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del personaje
    public Rigidbody2D rb2d;
    public float gravity = 30f;
    public bool isMoving = false;
    public Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        gravity = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravity = 25f;
        }
        MoverPersonaje();
    }

    void MoverPersonaje()
    {
        if (rb2d.velocity == Vector2.zero)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Physics2D.gravity = Vector2.up * gravity;

                rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                animator.SetBool("isMoving", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Physics2D.gravity = Vector2.down * gravity;

                rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                animator.SetBool("isMoving", true);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Physics2D.gravity = Vector2.left * gravity;

                rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                animator.SetBool("isMoving", true);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Physics2D.gravity = Vector2.right * gravity;

                rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                animator.SetBool("isMoving", true);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("isMoving", false);
        }
    }
}
