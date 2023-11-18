using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public float move;
    public float jump;
    public bool canJump = true;

    private Rigidbody2D rb;
    private Vector3 startPosition; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        startPosition = transform.position; 
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && canJump) 
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("Jump");
            canJump = false; 
        }


        if (transform.position.y < -10f)
        {
            ResetPlayerPosition(); 
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true; 
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = false; 
        }
    }

    void ResetPlayerPosition()
    {
        transform.position = startPosition; 
        rb.velocity = Vector2.zero; 
    }
}
