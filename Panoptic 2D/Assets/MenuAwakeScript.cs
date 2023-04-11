using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAwakeScript : MonoBehaviour
{
    [SerializeField] PlayerMovement hider;
    [SerializeField] SeekerScript seeker;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(hider);
        Destroy(seeker);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
