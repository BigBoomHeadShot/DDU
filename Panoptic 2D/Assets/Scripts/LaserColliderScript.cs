using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserColliderScript : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject SeekerW;
    [SerializeField] GameObject RestartMenu;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(collision.transform.gameObject);
            if (collision.gameObject.tag == "Player")
            {
                SeekerW.SetActive(true);
                RestartMenu.SetActive(true);
            }
        }
        
    }

}
