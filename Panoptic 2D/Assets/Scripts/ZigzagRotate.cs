using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigzagRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.y < -2 || transform.position.y > 2)
        {
            transform.eulerAngles = new Vector3(0,0,90);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
