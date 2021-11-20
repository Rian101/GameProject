using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        

            float moveHorizontal = direction;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f);
            rigidbody2D.velocity = movement * speed;

            if (target.position.x > enemyPosition.position.x)
            {

                direction = 1;

            }

            if (target.position.x < enemyPosition.position.x)
            {

                direction = -1;

            }



    }

}
