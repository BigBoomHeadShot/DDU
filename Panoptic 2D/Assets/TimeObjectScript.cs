using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeObjectScript : MonoBehaviour
{
    [SerializeField] TimerScript timer;
    public bool enabled = false;
    bool playerDetected;
    public float timeTo = 5;
    public float secCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (secCount < 0.1f && enabled == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(0, 1, 0, 0.3f), new Color(1, 0, 0, 0.3f), ((timeTo / 0.05f) / 100));
            if (playerDetected == true)
            {
                timeTo -= Time.deltaTime;
            }
            else if (timeTo < 5)
            {
                timeTo += Time.deltaTime;
            }
            if (timeTo < 0)
            {
                playerDetected = false;
                timer.timeRemaining += 60;
                transform.parent.GetComponent<TimeObjectTimer>().counter = 15;
                enabled = false;
            }
        
        }

        
        
        if (enabled == false && secCount < 1)
        {
            secCount += Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(gameObject.GetComponent<SpriteRenderer>().color.r, gameObject.GetComponent<SpriteRenderer>().color.g, gameObject.GetComponent<SpriteRenderer>().color.b, 0.3f), new Color(gameObject.GetComponent<SpriteRenderer>().color.r, gameObject.GetComponent<SpriteRenderer>().color.g, gameObject.GetComponent<SpriteRenderer>().color.b, 0f), secCount);
        }
        if (enabled == true && secCount > 0)
        {
            secCount -= Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(gameObject.GetComponent<SpriteRenderer>().color.r, gameObject.GetComponent<SpriteRenderer>().color.g, gameObject.GetComponent<SpriteRenderer>().color.b, 0.3f), new Color(gameObject.GetComponent<SpriteRenderer>().color.r, gameObject.GetComponent<SpriteRenderer>().color.g, gameObject.GetComponent<SpriteRenderer>().color.b, 0f), secCount);
        }

        if (enabled == false)
        {
            

        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" )
        {
            playerDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
        }
    }
}
