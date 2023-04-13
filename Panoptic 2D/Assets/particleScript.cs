using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleScript : MonoBehaviour
{
    ParticleSystem ptclsys;
    // Start is called before the first frame update
    void Start()
    {
         ptclsys = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ptclsys.isPlaying != true)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
