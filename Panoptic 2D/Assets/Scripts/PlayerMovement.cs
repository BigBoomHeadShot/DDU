using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    float hAxis;
    float vAxis;
    public float speed = 5;
    public float runSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        hAxis = Input.GetAxisRaw("HorizontalController");
        vAxis = Input.GetAxisRaw("VerticalController");

        if (Input.GetButton("runButton"))
        {
            body.velocity = new Vector2(hAxis * runSpeed, vAxis * runSpeed);
        }
        else
        {
            body.velocity = new Vector2(hAxis * speed, vAxis * speed);
        }


        
    }

}
