using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no_shape : MonoBehaviour
{
   

    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastPosition = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += speed * Time.deltaTime;
        }

        Vector2 newPosition = rb.position + movement;
        MoveCharacter(newPosition);
    }

    void MoveCharacter(Vector2 newPosition)
    {
        // Save the current position before moving
        lastPosition = rb.position;
        // Move to the new position
        rb.MovePosition(newPosition);
    }

    // Handle collisions to ensure the character doesn't bend position
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Revert to the last known position if a collision occurs
        rb.MovePosition(lastPosition);
    }


}
