using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float ammo;
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject holster;
    [SerializeField] Transform player;

    float delay = 0.5f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        ammo = holster.GetComponent<HolsterScript>().ammo;

        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            ammo--;
            Instantiate(prefab, transform.position, player.rotation);

        }
        timer += Time.deltaTime;
        if (Input.GetAxis("ShootingButton") == 1 && ammo > 0 && timer > delay)
        {
            ammo--;
            Instantiate(prefab, transform.position, player.rotation);
            timer = 0;
        }
    }
}
