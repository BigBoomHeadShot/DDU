using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 2000, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
