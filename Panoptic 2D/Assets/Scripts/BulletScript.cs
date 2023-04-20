using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject Pit;
    // Start is called before the first frame update
    void Start()
    {
        Pit = GameObject.FindWithTag("nonCollider");
        Physics2D.IgnoreCollision(Pit.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        Physics.IgnoreLayerCollision(5, 7);
        Vector3 v3Force = 400 * transform.up;
        gameObject.GetComponent<Rigidbody2D>().AddForce(v3Force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "Player")
        {
            Destroy(gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
