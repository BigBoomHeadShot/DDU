using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerScript : MonoBehaviour
{

    [SerializeField] GameObject muzzle;
    [SerializeField] GameObject shot;
    [SerializeField] float railSpeed;
    [SerializeField] float rotationSpeed;
    bool shootAble = true;
    bool moveable = true;
    private Vector3 mouse_pos;
    public Transform target;
    private Vector3 object_pos;
    private float angle;
    
    

    void Update()
    {
        if (moveable == true)
        {
            mouse_pos = Input.mousePosition;
            mouse_pos.z = -20;
            object_pos = Camera.main.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.y = mouse_pos.y - object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle), Time.deltaTime * rotationSpeed);
            //transform.rotation = Quaternion.Euler(0, 0, angle);


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
                {
                    
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    transform.position = Vector3.Lerp(transform.position , new Vector3(-3,0,0), Time.deltaTime * railSpeed);
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(3, 0, 0), Time.deltaTime * railSpeed);
                }
                



            }
        
        }



        if (shootAble == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine("Shoot");
            }
        }
        

    }


    private IEnumerator Shoot()
    {
        shootAble = false;
        muzzle.SetActive(true);
        yield return new WaitForSeconds(1);
        muzzle.SetActive(false);
        moveable = false;
        shot.SetActive(true);
        yield return new WaitForSeconds(1);
        shot.SetActive(false);
        moveable = true;
        yield return new WaitForSeconds(1);
        shootAble = true;
    }

}
