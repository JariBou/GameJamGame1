using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500f;

    private Rigidbody2D rb;
    private Vector2 moveVector;
    private CircleCollider2D collider;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        moveVector = new Vector2(x, y).normalized;
        rb.velocity = moveVector * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Void"))
        {
            transform.position = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        //rb.velocity = moveVector * (speed * Time.fixedDeltaTime);

    }
}
