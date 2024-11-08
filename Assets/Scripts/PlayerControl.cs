using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] private bool player1;

    private float speed = 5;

    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(0,1) * speed;
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0, -1) * speed;
            }
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0, 0);
            }
            
        }

        if (!player1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(0, 1) * speed;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(0, -1) * speed;
            }
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(0, 0);
            }

        }
        
    }
}
