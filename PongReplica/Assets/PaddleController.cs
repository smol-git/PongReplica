using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0f, -speed);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }

    }
}
