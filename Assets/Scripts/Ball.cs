using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool up;
    private bool right;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1,1,0) * Time.deltaTime);

        if (up)
        {
            rb.AddForce (new Vector2(0,0.1f));
        }
        if (!up)
        {
            rb.AddForce(new Vector2(0, -0.1f));
        }
        if(right)
        {
            rb.AddForce(new Vector2(0.1f, 0));  
        }
        if (!right)
        {
            rb.AddForce(new Vector2(-0.1f,0f));
        }
        //rb.AddForce(new Vector2(0.5f, 0.5f));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.velocity.y <= 0.09f)
        {
            up = !up;
        }
        if (rb.velocity.x <= 0.09)
        {
            right = !right;
        }
    }

    
}
