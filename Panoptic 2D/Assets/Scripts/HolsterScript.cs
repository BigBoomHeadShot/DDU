using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolsterScript : MonoBehaviour
{
    [SerializeField] GameObject gun;

    public float ammo;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gun.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            gun.SetActive(false);
        }

        if (Input.GetAxis("AimButton") == 1)
        {
            gun.SetActive(true);
        }
        else
        {
            gun.SetActive(false);
        }

        
    }
}
