using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float ammo;
    [SerializeField] GameObject prefab;
    [SerializeField] Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            ammo--;
            Instantiate(prefab, transform.position, player.rotation);

        }
    }
}
