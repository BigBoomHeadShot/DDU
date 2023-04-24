using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject holster;
    [SerializeField] Transform player;

    HolsterScript holsterScript;

    float delay = 0.5f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        holsterScript = holster.GetComponent<HolsterScript>();

    }
    

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && holsterScript.ammo > 0)
        {
            holsterScript.ammo--;
            Instantiate(prefab, transform.position, player.rotation);

        }
        timer += Time.deltaTime;
        if (Input.GetAxis("ShootingButton") == 1 && holsterScript.ammo > 0 && timer > delay)
        {
            holsterScript.ammo--;
            Instantiate(prefab, transform.position, transform.rotation);
            timer = 0;
        }

    }
}
