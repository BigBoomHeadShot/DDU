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

    public Transform spriteHolder;
    public GameObject Pit;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Pit = GameObject.FindWithTag("nonCollider");
        Physics2D.IgnoreCollision(Pit.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (body.velocity.x != 0 || body.velocity.y != 0)
        {
            spriteHolder.up = body.velocity.normalized;
        }
        movement();

        if (Input.GetButton("SpinButton"))
        {
            transform.Rotate(0, 0, 1500 * Time.deltaTime);
        }

        //Debug.Log("Aim " + Input.GetAxis("AimButton"));
        //Debug.Log("Shooting " + Input.GetAxis("ShootingButton"));
    }

    void movement()
    {
        hAxis = Input.GetAxisRaw("HorizontalController");
        vAxis = Input.GetAxisRaw("VerticalController");

        if (Input.GetButton("runButton") || Input.GetKeyDown(KeyCode.Keypad0))
        {
            body.velocity = new Vector2(hAxis * runSpeed, vAxis * runSpeed);
        }
        else
        {
            body.velocity = new Vector2(hAxis * speed, vAxis * speed);
            
        }


        //body.velocity = new Vector2(aHaxis * speed, aVaxis * speed);

    }

}
