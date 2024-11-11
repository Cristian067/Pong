using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallV2 : MonoBehaviour
{

    private Rigidbody2D rb;

    private float speed = 4;
    private float more = 1.2f;

    private bool up;
    private bool right;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GoGoBall();
        //rb.AddForce(new Vector2(10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1,1,0) * Time.deltaTime);

        
        //rb.AddForce(new Vector2(0.5f, 0.5f));

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.velocity *= more;
        }
        
    }
    
    private void GoGoBall()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        rb.velocity = new Vector2(xVelocity, yVelocity) * speed;
    }

}
