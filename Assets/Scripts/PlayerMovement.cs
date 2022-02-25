using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

    }

    
    void FixedUpdate()
    {

        //Key Inputs For Player Movement:

        if (Input.GetKey(KeyCode.A))
        {
           
             float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
             rBody.MovePosition(rBody.position + (Vector2.right * x));

        }

        else if (Input.GetKey(KeyCode.W))
        {
            float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
            rBody.MovePosition(rBody.position + (Vector2.up * y));

        }
        else if (Input.GetKey(KeyCode.S))
        {
            float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
            rBody.MovePosition(rBody.position + (Vector2.up * y));

        }
        else if (Input.GetKey(KeyCode.D))
        {
            float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
            rBody.MovePosition(rBody.position + (Vector2.right * x));

        }



    }
}

