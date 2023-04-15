using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] 
    float speed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, Random.Range(-1f, 1f));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Paddle"))
        {
            float velY = rb.velocity.y;
            velY = velY / 2f + other.gameObject.GetComponent<Rigidbody2D>().velocity.y / 3f;
            rb.velocity = new Vector2(-rb.velocity.x, velY);
        }
    }
}