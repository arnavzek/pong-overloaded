using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private float movement;
    public bool isPlayer1;
    public bool anotherAxis;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            if (anotherAxis)
            {
                movement = Input.GetAxisRaw("Vertical");
            }
            else
            {
                movement = Input.GetAxisRaw("Horizontal");
            }
           
        }
        else
        {
            if (anotherAxis)
            {
                movement = Input.GetAxisRaw("Vertical2");
            }
            else
            {
                movement = Input.GetAxisRaw("Horizontal2");
            }
        }

        if (anotherAxis)
        {
            rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        }
        else
        {
            rb.velocity = new Vector2( movement * speed, rb.velocity.y);
        }

       


    }
}
