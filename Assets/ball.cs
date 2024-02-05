using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour


{

    private Rigidbody2D rb;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1* speed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
