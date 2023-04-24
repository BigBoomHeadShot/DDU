using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    float hAxis;
    float vAxis;

    float hAim;
    float vAim;

    public float speed = 5;
    public float runSpeed = 10;


    [SerializeField] Transform gunRotate;
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

        hAim = Input.GetAxisRaw("HorizontalAim");
        vAim = Input.GetAxisRaw("VerticalAim");

        if (Input.GetButton("runButton") && hAxis > 0.3f || Input.GetButton("runButton") && vAxis > 0.3f || Input.GetButton("runButton") && vAxis < -0.3f || Input.GetButton("runButton") && hAxis > -0.3f)
        {
            body.velocity = new Vector2(hAxis * runSpeed, vAxis * runSpeed);
        }
        else if (hAxis > 0.3f || vAxis > 0.3f || vAxis < -0.3f || hAxis < -0.3f)
        {
            body.velocity = new Vector2(hAxis * speed, vAxis * speed);
            
        }
        else
        {
            body.velocity = Vector2.zero;
        }

        if (hAim > 0.3f || vAim > 0.3f || vAim < -0.3f || hAim < -0.3f)
        {
            float angle = Mathf.Atan2(-vAim, -hAim) * Mathf.Rad2Deg;
            gunRotate.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }



    }

}
