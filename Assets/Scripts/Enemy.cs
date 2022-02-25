using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 1.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Vector3 direction = Player.position - transform.position;             // Find distance from player to enemy positions:
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;  // Conversion to Radian:
        rb.rotation = angle;
        direction.Normalize();   
        movement = direction;

    }
    private void FixedUpdate()
    {
        moveEnemy(movement);            //Method Calling According to Movement Referance:
    }

    void moveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));  //Vector to vector 2 Conversion And Move to Player.
    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag.Equals("arc") == true)
        
        Destroy(gameObject);
    }
}
