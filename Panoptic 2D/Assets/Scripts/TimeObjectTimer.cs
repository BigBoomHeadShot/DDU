using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeObjectTimer : MonoBehaviour
{
    [SerializeField] TimeObjectScript timeObject;
    public float counter = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 0 && timeObject.enabled == false)
        {
            timeObject.enabled = true;
            timeObject.timeTo = 5;
            timeObject.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0);
        }
        if (counter > 0)
        {
            counter -= Time.deltaTime;
        }
        
        
    }
}
