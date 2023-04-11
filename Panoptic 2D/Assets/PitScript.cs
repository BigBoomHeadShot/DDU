using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitScript : MonoBehaviour
{
    [SerializeField] GameObject hider;
    [SerializeField] GameObject SeekerW;
    [SerializeField] GameObject RestartMenu;
    bool falling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (falling == true && hider.transform.localScale.x > 0.001f)
        {
            hider.transform.localScale = new Vector3(hider.transform.localScale.x - 0.3f * Time.deltaTime, hider.transform.localScale.y - 0.3f * Time.deltaTime, hider.transform.localScale.z);
        }
        if (hider.transform.localScale.x < 0.001f)
        {
            SeekerW.SetActive(true);
            RestartMenu.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            falling = true;
            Destroy(collision.gameObject.GetComponent<PlayerMovement>());
        }
    }
}
