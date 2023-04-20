using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HardLight2DUtil;

public class particleScript : MonoBehaviour
{
    ParticleSystem ptclsys;
    [SerializeField] HardLight2D light;
    // Start is called before the first frame update
    void Start()
    {
         ptclsys = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (light.Intensity < 1)
        {
            light.Intensity += 0.05f;
        }
        
        if (ptclsys.isPlaying != true)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
