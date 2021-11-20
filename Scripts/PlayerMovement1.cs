using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement1 : MonoBehaviour
{
    private Rigidbody2D rb;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * 4f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 8f);
        }
        
           

    }
}
